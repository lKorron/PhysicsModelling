using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChooser : MonoBehaviour
{
    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene(0);
    }
}
