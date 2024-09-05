using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static UnityEngine.UI.GridLayoutGroup;

public class Tooltip : MonoBehaviour
{
    public TMP_Text text;
    [SerializeField] Canvas _canvas;
    [SerializeField] RectTransform _parentTransform, _box;
    [SerializeField] Camera _camera;

    void OnEnable()
    {
        Hoverable.Show += ShowTooltip;
        Hoverable.Hide += HideTooltip;
    }
    void OnDisable()
    {
        Hoverable.Show -= ShowTooltip;
        Hoverable.Hide -= HideTooltip;
    }
    public void ShowTooltip(Vector2 screenPosition, string tooltipText)
    {
        _box.gameObject.SetActive(true);

        Vector3[] corners = new Vector3[4];
        _box.GetLocalCorners(corners);

        float height = Vector2.Distance(corners[0], corners[1]);
        float width = Vector2.Distance(corners[0], corners[3]);

        _parentTransform.GetLocalCorners(corners);

        float parentheight = Vector2.Distance(corners[0], corners[1]);
        float parentWidth = Vector2.Distance(corners[0], corners[3]);

        Vector2 localPosition;
        RectTransformUtility.ScreenPointToLocalPointInRectangle
            (_parentTransform,
            screenPosition,
            _canvas.renderMode == RenderMode.ScreenSpaceOverlay ? null : _camera,
            out localPosition);

        float currentY = localPosition.y;
        float currentX = localPosition.x;

        if(currentY + height >= parentheight/2)
        {
            currentY = localPosition.y - height;
        }
        if(currentX + width >= parentWidth/2)
        {
            currentX = localPosition.x - width;
        }

        _box.anchoredPosition = new Vector2(currentX, currentY);
        text.text = tooltipText;
    }

    public void HideTooltip()
    {
        _box.gameObject.SetActive(false);
    }
}
