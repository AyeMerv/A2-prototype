using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DelayedTransition : MonoBehaviour
{
    public float delayTime = 1f;
    public int sceneID = 1;

    public Animator animator;
    public Image white;

    public void NormalDelayedTransition()
    {
        Invoke("LoadSceneById", delayTime);
    }

    public void DelayedScene()
    {
        StartCoroutine(Fading());
    }

    
    private void LoadSceneById()
    {
        SceneManager.LoadScene(sceneID);
    }

    IEnumerator Fading()
    {
        animator.SetBool("Fade", true);
        yield return new WaitUntil(() => white.color.a == 1);
        Invoke("LoadSceneById", delayTime);
    }
}