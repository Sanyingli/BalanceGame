using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class HUD : MonoBehaviour {

    public string lvName = "level2";

    public Text score;
    public Button nextLvButton;
    public Button openMenu;
    public Button confirmButton;

    public Toggle mute;

    public Slider volume;

    public GameObject menu;

	// Use this for initialization

    void Awake()
    {
        volume.value = 1;
        menu.SetActive(false);
        Button btn = nextLvButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        Button openbt = openMenu.GetComponent<Button>();
        openbt.onClick.AddListener(OpenMenu);

        Button comBut = confirmButton.GetComponent<Button>();
        comBut.onClick.AddListener(CloseMenu);

    }
	
	// Update is called once per frame
	void Update () {
        score.text = "Score:" + GameMan.socre;
      
        if(mute.isOn == false)
        {
            AudioListener.volume =  volume.value;
        }
        if (mute.isOn == true)
        {
            AudioListener.volume = 0;
        }
    }

    public void GameOver()
    {
        float time = Time.time;
        if (time - 0 > 4)
        {
            Animator anim = GetComponent<Animator>();
            anim.SetTrigger("GameOver");
        }
    }

    public void GameWin()
    {
        //Debug.Log("gameWin");
        Animator anim = GetComponent<Animator>();
        anim.SetTrigger("GameWin");
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene(lvName);

    }

    void OpenMenu()
    {
        menu.SetActive(true);
        Time.timeScale = 0;
    }

    void CloseMenu()
    {
        menu.SetActive(false);
        Time.timeScale = 1;
    }

    public void ShowAds()
    {
        ShowOptions options = new ShowOptions { resultCallback = AdsResult };
        Advertisement.Show("video", options);
    }

    void AdsResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                Debug.Log("The ad was successfully shown.");
                //
                // YOUR CODE TO REWARD THE GAMER
                // Give coins etc.
                break;
            case ShowResult.Skipped:
                Debug.Log("The ad was skipped before reaching the end.");
                break;
            case ShowResult.Failed:
                Debug.LogError("The ad failed to be shown.");
                break;
        }
    }
}
