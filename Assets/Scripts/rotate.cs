using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft;
using System.Security.Cryptography;
using System;

public class rotate : MonoBehaviour {

    public GameObject setreset;
    private float x = 0;
    private float y = 0;
    public float z = 10;
    private int count = 1;
    public float reduce;

    // Use this for initialization
    void Start () {
       // Debug.Log((DateTime.Now.ToUniversalTime()- new DateTime(2010,1,1)).TotalSeconds);
        
        reduce = (float)UnityEngine.Random.Range(4,8)/400;
    }
	
	// Update is called once per frame
	void Update () {
        if(z>0)
        {
            transform.Rotate(x, y, z);
            z = z - reduce ;

        }
        if (z<0 && count > 0)
        {
            count--;
            setreset.SetActive(true);
           
        }
	}

    public void respin()
    {
        z = 10;
        reduce = (float)UnityEngine.Random.Range(4, 8) / 400;
        setreset.SetActive(false);

    }

}
