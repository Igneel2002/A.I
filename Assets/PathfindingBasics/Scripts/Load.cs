using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    public void LOAD()
    {
        SceneManager.LoadScene("MAZE");
    }

    public void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            Screen.lockCursor = false;
            SceneManager.LoadScene("StartMenu");
        }
    }

    public void EXIT()
    {
#if     UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
