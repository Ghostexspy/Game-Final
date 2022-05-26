using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// This just loads the actuall game scene from the title scene
public class StartGame : MonoBehaviour
{
    public string LevelName;

    public void LoadLevel()
    {
        SceneManager.LoadScene(LevelName);
    }
}
