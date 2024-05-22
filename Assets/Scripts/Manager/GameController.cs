using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public string restartScene = "CharacterChoice";
   public void EndGame()
    {
        Debug.Log("E");
        UnityEditor.EditorApplication.isPlaying = false;

        Application.Quit();
    }

    public void ResetGame()
    {
        Debug.Log("E");
        SceneManager.LoadScene(1);
    }
}
