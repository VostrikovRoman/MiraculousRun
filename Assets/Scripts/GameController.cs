using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public bool move = true;
    public GameObject GameScene;
    public GameObject UI;
    public GameObject Menu;
    public GameObject Settings;
    public GameObject Skins;
    public GameObject Scores;
    public GameObject GameOver;
    public GameObject Background;

    public bool startGame = false;

    public GameObject Player;
    public GameObject Enemy;

    public Health gameAgain;
    public Energy gameAgain2;

    public int num_skin;


    public string[] skins = { "ladybug", "cat", "fox", "bee", "turtle", "peacock", "butterfly", "rabbit", "dog", "dragon", "snake", "mouse", "ox",
    "tiger", "pig", "rooster", "goat", "monkey", "horse"};

    public void Start()
    {
        num_skin = PlayerPrefs.GetInt("num_skin");
    }
    
    public void BackToMenu()
    {
        GameScene.SetActive(false);
        GameOver.SetActive(false);
        UI.SetActive(false);
        //Skins.SetActive(false);
        Settings.SetActive(false);
        //Scores.SetActive(false);
        Menu.SetActive(true);
        Background.SetActive(true);
    }
    public void ToMenu()
    {
        Settings.SetActive(false);
        Skins.SetActive(false);
        Menu.SetActive(true);
        Scores.SetActive(false);
        PlayerPrefs.SetInt("num_skin", num_skin);
    }
    public void StartGame()
    {
        GameScene.SetActive(true);
        UI.SetActive(true);
        Menu.SetActive(false);
        Background.SetActive(false);
        GameOver.SetActive(false);
        move = true;
        gameAgain.GameAgain();
        gameAgain2.GameAgain();
        num_skin = PlayerPrefs.GetInt("num_skin");
    }

    public void ToSettings()
    {
        Menu.SetActive(false);
        Settings.SetActive(true);
    }

    public void ToSkins()
    {
        Menu.SetActive(false);
        Skins.SetActive(true);
    }
    public void ToScores()
    {
        Menu.SetActive(false);
        Scores.SetActive(true);
    }

    //For Skins//
    public void BackBow()
    {
        if (num_skin > 0)
        {
            num_skin -= 1;
        }
        PlayerPrefs.SetInt("num_skin", num_skin);
    }
    public void NextBow()
    {
        if (num_skin < 18)
        {
            num_skin += 1;
        }
        PlayerPrefs.SetInt("num_skin", num_skin);
    }
}
