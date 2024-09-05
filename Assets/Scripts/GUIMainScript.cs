using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIMainScript : MonoBehaviour
{
    [SerializeField] View _view;
    [SerializeField] List<GameObject> _prefabs;

    [SerializeField] Button _prevObject, _nextObject;
    [SerializeField] Button _prevAction, _nextAction, _invokeAction;

    private void Awake()
    {
        Model model = new GUIModel(_view, _prefabs);
        Controller controller = new GUIController(_view, model);

        _prevObject.onClick.AddListener(() => controller.PreviousObject());
        _nextObject.onClick.AddListener(() => controller.NextObject());
        _prevAction.onClick.AddListener(() => controller.PreviousAction());
        _nextAction.onClick.AddListener(() => controller.NextAction());
        _invokeAction.onClick.AddListener(() => controller.InvokeAction());
    }
}
