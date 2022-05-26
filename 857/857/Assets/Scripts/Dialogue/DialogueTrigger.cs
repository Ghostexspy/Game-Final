using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This calls the DialogueManager to begin the dialogue when its triggered
public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue ()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
