using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    [Header("UI")]
    //EnemyList
    public GameObject enemyList;

    //Life
    public Image lifeImg;
    public TextMeshProUGUI lifeText;

    //Level
    public Image levelImg;
    public TMP_Text levelText;

    [Header("Player Stats")]
    [SerializeField] int score;
    [SerializeField] int highScore;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void AddScore(int value)
    {
        score += value;
    }
}