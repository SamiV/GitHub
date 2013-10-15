using UnityEngine;
using System.Collections;
 
public class PrintFPS : MonoBehaviour 
{
	private float slowestFrame = 0.00001f;
	private int frameCounter = 0;

	void Start()
	{
	    Application.targetFrameRate = 60;
	}
	 
	void OnGUI()
	{
		// Reset the slowest frame every 30 frames to see new spikes
		if( Time.deltaTime > slowestFrame || frameCounter == 180 )
		{
			slowestFrame = Time.deltaTime;
			frameCounter = 0;
		}
		
		GUI.Label(new Rect( 0, 0, Screen.width, Screen.height), System.String.Format("{0:F2} (frame ms)", Time.deltaTime * 1000.0f) );
		GUI.Label(new Rect( 0, 20, Screen.width, Screen.height), System.String.Format("{0:F2} (slowest ms)", slowestFrame * 1000.0f) );
		frameCounter++;
	}
}