using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour {

    public Button[] lvButton;
    string lvReach = "lvReach";

	// Use this for initialization
	void Start () {

         int lvReached = PlayerPrefs.GetInt(lvReach, 1);

        Debug.Log(lvReached);

        for (int i = 0; i < lvButton.Length; i++)
        {
            if (i > lvReached - 1)
            {
                lvButton[i].interactable = false;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Test()
    {
        Debug.Log("This button work");
    }

    public void SetLvReach(int _lvNumber)
    {
        PlayerPrefs.SetInt(lvReach, _lvNumber);
    }

    public void ReSetData()
    {
        PlayerPrefs.DeleteAll();
    }
}
