using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    // General method to load scenes based on build index
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
