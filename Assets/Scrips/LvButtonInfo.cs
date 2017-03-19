using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LvButtonInfo : MonoBehaviour {

    public Image[] stars;
    public string lvName;


	// Use this for initialization
	void Start () {
        int lvStarStarter = PlayerPrefs.GetInt(lvName, 0);
        int lvStarNumber = PlayerPrefs.GetInt(lvName);

        for (int i = 0; i < stars.Length; i++)
        {
            stars[i].enabled = false;
        }

        for (int i = 0; i < lvStarNumber; i++)
        {
            stars[i].enabled = true;
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void EnterLv()
    {
        SceneManager.LoadScene(lvName);
    }
}
