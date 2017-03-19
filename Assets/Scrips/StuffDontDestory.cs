using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StuffDontDestory : MonoBehaviour {

    static StuffDontDestory instance;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
