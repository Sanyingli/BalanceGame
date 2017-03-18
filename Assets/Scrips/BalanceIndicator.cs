using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BalanceIndicator : MonoBehaviour {

    public Slider slider;

    private float mVio = 0.0f;
    public float mySmoothTime = 0.2f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float balance = Player.balance;
        float rate = balance / 100;
        float smooth = Mathf.SmoothDamp(slider.value, rate, ref mVio, mySmoothTime);
        slider.value = smooth;

	}
}
