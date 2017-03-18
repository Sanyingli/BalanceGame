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
            HUD hud = hudObj.GetComponent<HUD>();
            hud.GameWin();
            Player pl = player.GetComponent<Player>();
            pl.enabled = false;
  

        }
    }

	public void Restart(){
		SceneManager.LoadScene (0);
		Time.timeScale = 1;
	}
}
