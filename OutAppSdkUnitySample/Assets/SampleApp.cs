using UnityEngine;
using System.Collections;

public class SampleApp : MonoBehaviour {	
	

	
	// Use this for initialization
	void Start () {
	
	}
	
    void OnGUI()
    {
		int x = 15;
        int y = 5;
        int pad = 20;
		int h = 60;
		int width = 1000;
		y += h + pad+10+20;

	       //   scrollViewVector = GUI.BeginScrollView (new Rect (0,0,Screen.width,Screen.height), scrollViewVector, new Rect (0,0,Screen.width-1,1000));
		
		    AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity");

		
		y += h + pad;
		if (GUI.Button(new Rect(x, y, width, h), "out app sdk"))
        {
	          
        }

		//GUI.EndScrollView();      
    }
		// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Home))
        {
            Application.Quit();
        }
	}
	
	





	
}
