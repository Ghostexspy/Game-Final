using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This script allows you use a text box and a string to write what you want as dialogue
[System.Serializable]
public class Dialogue
{
    public string name;

    [TextArea(3,9)]
    public string[] sentences;

}
