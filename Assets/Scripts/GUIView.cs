using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GUIView : View
{
    [SerializeField] private TMP_Text _nameText;
    [SerializeField] private TMP_Text _descriptionText;
    [SerializeField] private TMP_Text _actionText;
    public override void DisplayName(string name)
    {
        _nameText.text = name;
    }
    public override void DisplayDescription(string description)
    {
        _descriptionText.text = description;
    }
    public override void DisplayAction(string actionName)
    {
        _actionText.text = actionName;
    }
}
