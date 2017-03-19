using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPoint : MonoBehaviour {

    public GameObject hudObj;
    public GameObject player;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Debug.Log("You Win!");
            SetStarNumber();
            HUD hud = hudObj.GetComponent<HUD>();
            hud.GameWin();
            Player pl = player.GetComponent<Player>();
            pl.enabled = false;
  

        }
    }

	public void Restart(){
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
		Time.timeScale = 1;
	}

    void SetStarNumber()
    {
        string lvName = SceneManager.GetActiveScene().name;
        int starNumerReach = PlayerPrefs.GetInt(lvName);
        int score = GameMan.score;
        
        if (starNumerReach < score)
        {
            PlayerPrefs.SetInt(lvName, score);
        }

        int lvReached = PlayerPrefs.GetInt("lvReach");
        int currentLv = SceneManager.GetActiveScene().buildIndex;
        if (lvReached < currentLv + 1)
        {
            Debug.Log("currentLv:" + currentLv);
            PlayerPrefs.SetInt("lvReach", currentLv+1);
        }
    }

    public void BackMainScene()
    {
        SceneManager.LoadScene(0);
    }
}
