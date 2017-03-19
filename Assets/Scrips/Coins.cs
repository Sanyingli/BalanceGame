using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour {

    GameObject hud;
    HUD hudScript;
    // Use this for initialization
    private void Awake()
    {
        hud = GameObject.FindGameObjectWithTag("HUD");
    }

    void Start () {
        hudScript = hud.GetComponent<HUD>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Player") {
            //Debug.Log("score +10");
            GameMan.score += 1;
            hudScript.StarUpdate(GameMan.score);
            Destroy(this.gameObject);
        }
        }
    }
