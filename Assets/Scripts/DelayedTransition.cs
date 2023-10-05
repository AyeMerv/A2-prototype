using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DelayedTransition : MonoBehaviour
{
    public float delayTime = 1f;
    public int sceneID = 1;

    public void DelayedScene()
    {
        Invoke("LoadSceneById", delayTime);
    }

    
    private void LoadSceneById()
    {
        SceneManager.LoadScene(sceneID);
    }
}