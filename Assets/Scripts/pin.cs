using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pin : MonoBehaviour {

    public rotate _rotate;
    public Text text;
	// Use this for initialization
	void Start () {
		
	}
    /*void Update()
    {
        
        Debug.Log(this.GetComponent<rotate>().z);
        if (GetComponent<rotate>().z < 0)
        {
            string col = this.GetComponent<Collider2D>().gameObject.name;
            Debug.Log(col);
        }
    }*/

    // Update is called once per frame
    void OnTriggerStay2D(Collider2D col)
	{
        //Debug.Log("addddd");
		if(_rotate.z<0)
		{
            text.text = "Ypu Have Won :" + col.gameObject.name;

			//Debug.Log(col.gameObject.name);
		}
	}
}
