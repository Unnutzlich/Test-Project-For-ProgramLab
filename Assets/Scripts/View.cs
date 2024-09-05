using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class View : MonoBehaviour 
{ 
    public abstract void DisplayName(string name);
    public abstract void DisplayDescription(string description);
    public abstract void DisplayAction(string actionName);
}
