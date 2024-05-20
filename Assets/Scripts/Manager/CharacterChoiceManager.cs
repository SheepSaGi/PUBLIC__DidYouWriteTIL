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

    void Start()
    {
        Giwoong.onClick.AddListener(() => CharacterChoiceBtn("Giwoong"));
        JiYoon.onClick.AddListener(() => CharacterChoiceBtn("JiYoon"));
        Jihyo.onClick.AddListener(() => CharacterChoiceBtn("Jihyo"));
        Sunho.onClick.AddListener(() => CharacterChoiceBtn("Sunho"));
    }

    public void CharacterChoiceBtn(string characterName)
    {
        PlayerPrefs.SetString("setPlayerName", characterName);
        SceneManager.LoadScene("MainScene");
        Debug.Log(characterName);
    }


}
