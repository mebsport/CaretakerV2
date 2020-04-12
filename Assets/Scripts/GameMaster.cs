using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    public Text score;

    private string scoreValue;

    private bool hasLost;

    public GameObject restartPanel;

    public AdManager adManager;
    public DragAndDrop dragAndDrop1;
    public DragAndDrop dragAndDrop2;
    public DragAndDrop dragAndDrop3;
    public DragAndDrop dragAndDrop4;
    public DragAndDrop dragAndDrop5;
    public DragAndDrop dragAndDrop6;

    private int finalScore;
    private int milkQuantity;

    private void Start()
    {

    }
    private void Update()
    {
        milkQuantity = PlayerPrefs.GetInt("MilkAmmount");
        if(hasLost == false)
        {
            scoreValue = Time.timeSinceLevelLoad.ToString("F0");
            score.text = scoreValue;
            
        }
    }
    public void GameOver()
    {
        dragAndDrop1.GameOver();
        dragAndDrop2.GameOver();
        dragAndDrop3.GameOver();
        dragAndDrop4.GameOver();
        dragAndDrop5.GameOver();
        dragAndDrop6.GameOver();

        int.TryParse(scoreValue, out finalScore);
        PlayerPrefs.SetInt("MilkAmmount",milkQuantity + finalScore);

        float randomNumber = Random.Range(0, 100);
        
        if(randomNumber < 34)
        {
            adManager.DisplayInterstitialAD();
            hasLost = true;
            restartPanel.SetActive(true);
        }
        else
        {
            hasLost = true;
            restartPanel.SetActive(true);
        }
    }
    public void GoToGameMenu()
    {
        SceneManager.LoadScene("Menu2");
    }
    public void GoToHelpPage()
    {
        SceneManager.LoadScene("Help");
    }
    public void EndlessMode()
    {
        SceneManager.LoadScene("Endless");
    }
    public void SurvivalMode()
    {
        SceneManager.LoadScene("Survival");
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }
    public void AboutPage()
    {
        SceneManager.LoadScene("About");
    }
    public void OpenPrivacyPolicy()
    {
        Application.OpenURL("https://medium.com/@adventitious.studios/caretaker-privacy-4fda331620af");
    }
}
