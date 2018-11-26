using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

//controls timer usage as well as button navigation
//some elements from N3K EN Timer video on Youtube https://youtu.be/x-C95TuQtf0
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

        //determines if we have won yet
        GameManager.Instance.victory = false;

        trumpet = GetComponent<AudioSource>();
        //counter used to limit amount of win signals
        counter = 0;

        SceneName = SceneManager.GetActiveScene().name;
    }
	
	// Update is called once per frame
	void Update () {
        //counts and updates timer text
        if (GameManager.Instance.victory == true)
            return;
        float t = Time.time - startTime;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        timerText1.text = SceneName + " - " + minutes + ":" + seconds;
        //shows buttons if dead
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
            //stops timer
            GameManager.Instance.victory = true;
            timerText1.color = Color.gray;
            trumpet.Play();

            //updates static timer 1 and 2
            if (SceneName == "Level_1")
                GameManager.time1 = timerText1.text;
            else if (SceneName == "Level_2")
                GameManager.time2 = timerText1.text;

            //reveals buttons or text
            MainMenuButton.SetActive(true);
            NextButton.SetActive(true);
            if (SceneName == "Level_3")
                WinnerText.SetActive(true);
            counter++;
        }
    }

    //general button navigation below
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
