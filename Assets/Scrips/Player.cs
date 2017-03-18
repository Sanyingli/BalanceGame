using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public static float balance = 50;
    public int limit = 100;
    public float updateRate = 2f;

    private float lastTime = 0;

    public BalanceIndicator bi;
    public GameObject hudObj;
	// Use this for initialization
	void Start () {
		balance = 50;
        Random.InitState(System.Guid.NewGuid().GetHashCode());
	}
	
	// Update is called once per frame
	void Update () {

		float x = Input.acceleration.x;
        //X> 0 is right, x <0 is left.


        //add random force
        /*
        float time = Time.time;
        if(time - lastTime > updateRate)
        {
            //Debug.Log("add");
            ForceAdd();
            lastTime = time;
        }
        */
    
        //balance value check
        if(balance > limit || balance < 0)
        {
            //Debug.Log("Game Over!");
            HUD hud = hudObj.GetComponent<HUD>();
            hud.GameOver();
            Animator anim = GetComponent<Animator>();
            anim.SetTrigger("Faint");
            Collider2D cd = GetComponent<BoxCollider2D>();
            Collider2D cd2 = GetComponent<CircleCollider2D>();
            cd.enabled = false;
            cd2.enabled = false;

            this.enabled = false;
        }

        //control
		/*
        if(Input.GetKeyDown("z")|| x > 0)
        {
			balance -= 5*x;
            Debug.Log(balance);
        }
        if (Input.GetKeyDown("x")|| x < 0)
        {
			balance += 5*Time.deltaTime;
            Debug.Log(balance);
        }
        */
		balance += 50 * x*Time.deltaTime;

    }

    void ForceAdd()
    {
        if (balance < 35)
        {
            int random1 = Random.Range(-20, -10);
            balance += random1;
        }
        else if (balance > 65)
        {
            int random2 = Random.Range(10, 20);
            balance += random2;
        }
        else
        {
            int random = Random.Range(-20, 20);
            balance += random;
        }
        //Debug.Log(balance);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "Rope")
        {
            float time = Time.time;
            if (time - lastTime > updateRate)
            {
                //Debug.Log("add");
                ForceAdd();
                lastTime = time;
            }
        }
    }

}
