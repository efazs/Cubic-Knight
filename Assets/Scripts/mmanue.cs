using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mmanue : MonoBehaviour {

    public GameObject loadingscreeen;
	public Slider slider;
	public Button nxt;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	

	public void nxtscn()
	{
		loadingscreeen.SetActive(true);
        
		//SceneManager.LoadScene("SampleScene");
		StartCoroutine(LoadBar("SampleScene"));
	}

	IEnumerator LoadBar(string scenename)
	{
		AsyncOperation operation = SceneManager.LoadSceneAsync(scenename);
        operation.allowSceneActivation = false;
        while(!operation.isDone)
        {
            float progress = operation.progress ;

            // Debug.Log(operation.progress);
            slider.value = progress;

            if(operation.progress == .9f)
            {
                slider.value = 1f;
                loadingscreeen.SetActive(false);
                operation.allowSceneActivation = true;
                
                
            }
            yield return null;
        }
			

		
		
	}
    public void nxtspin()
    {



        SceneManager.LoadScene("spinner");
    }
}
