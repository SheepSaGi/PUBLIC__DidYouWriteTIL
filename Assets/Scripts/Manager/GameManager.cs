using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int score = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI TILscore;
    public Transform Player { get; private set; }
    public ObjectPool ObjectPool { get; private set; }
    [SerializeField] private string playerTag = "Player";

    public GameObject gameOverUI;
    public GameObject gameUI;
    public GameObject playerUI;
    private void Awake()
    {
        Instance = this;
        Player = GameObject.FindGameObjectWithTag(playerTag).transform;

        ObjectPool = GetComponent<ObjectPool>();
    }

    private void Start()
    {
        InvokeRepeating("AddTIL", 1.0f, 1.0f);
    }

    private void AddTIL()
    {
        score += 1;
        AddScore();
    }

    private void AddScore()
    {
        scoreText.text = score.ToString();
    }
    public void PlayerDeath()
    {
        gameUI.SetActive(false);
        playerUI.SetActive(false);
        gameOverUI.SetActive(true); // 게임 오버UI활성화
        Time.timeScale = 0; // 게임 시간 정지
    }
}
