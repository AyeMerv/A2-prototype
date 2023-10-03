using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //importing TextMeshPro

public class TextManager : MonoBehaviour
{
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI dialogueText;
    public float typingSpeed = 0.1f;

    public Animator animator;

    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue (Dialogue dialogue)
    {

        animator.SetBool("isOpen", true);

        titleText.text = dialogue.title;
        
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence, typingSpeed));
    }

    IEnumerator TypeSentence (string sentence, float typingSpeed)
    {
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    void EndDialogue()
    {
        animator.SetBool("isOpen", false);
    }

}
