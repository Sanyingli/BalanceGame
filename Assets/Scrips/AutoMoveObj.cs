using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMoveObj : MonoBehaviour {
    public float speed = 2f;

    private GameObject player;
    private Player playerS;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        playerS = player.GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += Vector3.left * speed * Time.deltaTime;
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {  
            playerS.GameOver();
        }
    }
}
