using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initiate : MonoBehaviour {


    public GameObject original;
    public GameObject fake;
    public GameObject button_spin;
    public GameObject button_respin;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Init()
    {
        button_spin.SetActive(false);
        button_respin.SetActive(true);
        original.SetActive(true);
        fake.SetActive(false);

    }

}
