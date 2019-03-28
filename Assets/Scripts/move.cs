using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class move : MonoBehaviour {

    // Use this for initialization

    public Camera camera;
    private RaycastHit hit;
    private Ray ray;
    private GameObject hitObject = null;
    public Text text;
    private int j = 0;
    public Slider slider;
    public float timer = 5;
    public GameObject panel;
	void Start () {
        Vector3 newPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if(timer > 0f)
        {
            timer = timer-Time.deltaTime;
            slider.value = timer;
        }
        else if(timer < 0)
        {
            panel.SetActive(true);
        }


        if(Input.GetMouseButtonDown(0))
        {
            ray = camera.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray,out hit))
            {
                if(hit.collider.tag=="tile")
                {
                    
                    hitObject = hit.collider.gameObject;
                    foreach(GameObject something in GetComponent<Creation>().Available)
                    {
                        if(hitObject==something)
                        {
                            j++;
                            text.text = j.ToString();
                            transform.position = hitObject.transform.position;
                           GetComponent<Creation>().HighliteTiles((int)(hitObject.transform.position.x)/2, (int)(hitObject.transform.position.z)/2);
                            break;
                        }
                            

                    }
                    
                }
            }
        }
		
	}
   /* public void Reset()
    {
        GetComponent<Creation>().reset();
    }*/
    
    
}
