using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanStuff : MonoBehaviour {

    public GameObject objToSpwan;
    public Transform spwanPoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Instantiate(objToSpwan,spwanPoint,false);

            Destroy(gameObject);
        }
    }
}
