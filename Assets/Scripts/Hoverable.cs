using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoverable : MonoBehaviour
{
    public delegate void HideTTip();
    public delegate void ShowTTip(Vector2 position, string tooltipText);
    public static event ShowTTip Show;
    public static event HideTTip Hide;

    [SerializeField] string _tooltipText;
    void OnMouseOver()
    {
        Show?.Invoke(Input.mousePosition, _tooltipText);
    }
    private void OnMouseExit()
    {
        Hide?.Invoke();
    }
}
