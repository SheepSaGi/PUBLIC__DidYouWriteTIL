using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterChoiceManager : MonoBehaviour
{
    [SerializeField] Button Giwoong;
    [SerializeField] Button JiYoon;
    [SerializeField] Button Jihyo;
    [SerializeField] Button Sunho;
    private string setPlayerName = "Player";

    public void GiwoongBtn()
    {
        setPlayerName = "Giwoong";
        PlayerPrefs.SetString("setPlayerName", setPlayerName);
        SceneManager.LoadScene("MainScene");
    }

    public void JiYoonBtn()
    {
        setPlayerName = "JiYoon";
        PlayerPrefs.SetString("setPlayerName", setPlayerName);
        SceneManager.LoadScene("MainScene");
    }
    
    public void JihyoBtn()
    {
        setPlayerName = "Jihyo";
        PlayerPrefs.SetString("setPlayerName", setPlayerName);
        SceneManager.LoadScene("MainScene");
    }

    public void SunhoBtn()
    {
        setPlayerName = "Sunho";
        PlayerPrefs.SetString("setPlayerName", setPlayerName);
        SceneManager.LoadScene("MainScene");
    }
    


    //public void CharacterChoiceBtn()
    //{


    //    SceneManager.LoadScene("MainScene");
    //}

   
   
}
