using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeleteObject : MonoBehaviour
{
    public AudioClip clickSound;
    private static int objectCount = 0;
    public string nextSceneName;
    public Animator animator;

    private void Start()
    {
        objectCount++;
    }

    void OnMouseDown()
    {
        if (clickSound != null)
        {
            AudioSource.PlayClipAtPoint(clickSound, transform.position);
        }

        Destroy(gameObject);
        objectCount--;

        if (objectCount <= 0 && animator != null)
        {
            animator.SetBool("allGemsGone", true);
        }

    }
}