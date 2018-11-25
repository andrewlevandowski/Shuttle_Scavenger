using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    public Text timerText1;
    private float startTime;
    AudioSource trumpet;
    private int counter;
    public GameObject MainMenuButton;
    public GameObject NextButton;
    public GameObject RetryButton;
    public GameObject WinnerText;
    string SceneName;

    // Use this for initialization
    void Start () {
        startTime = Time.time;
        GameManager.Instance.victory = false;
        trumpet = GetComponent<AudioSource>();
        counter = 0;
        SceneName = SceneManager.GetActiveScene().name;
    }
	
	// Update is called once per frame
	void Update () {
        if (GameManager.Instance.victory == true)
            return;
        float t = Time.time - startTime;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        timerText1.text = SceneName + " - " + minutes + ":" + seconds;
        if (GameManager.Instance.destroyed == true)
        {
            RetryButton.SetActive(true);
            MainMenuButton.SetActive(true);
        }
	}

    void Winner()
    {
        if (counter == 0)
        {
            GameManager.Instance.victory = true;
            timerText1.color = Color.gray;
            trumpet.Play();
            if(SceneName == "Level_1")
                GameManager.Instance.time1 = timerText1.text;
            else if(SceneName == "Level_2")
                GameManager.Instance.time2 = timerText1.text;
            MainMenuButton.SetActive(true);
            NextButton.SetActive(true);
            if (SceneName == "Level_3")
                WinnerText.SetActive(true);
            counter++;
        }
    }

    public void gotoMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void gotoLevel2() {
        SceneManager.LoadScene("Level_2");
    }

    public void gotoLevel3()
    {
        SceneManager.LoadScene("Level_3");
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneName);
    }
}
