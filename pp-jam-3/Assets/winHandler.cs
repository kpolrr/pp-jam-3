using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winHandler : MonoBehaviour
{
    public void restart()
    {
        SceneManager.LoadScene(1);
        SceneManager.UnloadSceneAsync(2);
    }
}
