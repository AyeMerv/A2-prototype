using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryTrigger : MonoBehaviour
{

    public Dialogue dialogue;

    public void TriggerDialogue ()
    {
        FindObjectOfType<TextManager>().StartDialogue(dialogue);
    }

}
