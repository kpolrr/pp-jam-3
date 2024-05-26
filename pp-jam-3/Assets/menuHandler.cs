using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuHandler : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene(1);
        SceneManager.UnloadSceneAsync(0);
        SceneManager.UnloadSceneAsync(2);
    }
}
