using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
   public void EndGame()
    {
        Debug.Log("End");
        UnityEditor.EditorApplication.isPlaying = false;

        Application.Quit();
    }

    public void ResetGame()
    {
        Debug.Log("RE");
        Time.timeScale = 1.0f;
        SoundManager.Sound.Clear();
        SceneManager.LoadScene(1);
    }
}
