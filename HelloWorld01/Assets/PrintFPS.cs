using UnityEngine;
using System.Collections;
 
public class PrintFPS : MonoBehaviour 
{
	public int resetFrameCounterCount = 180; // Reset the slowest frame every N frames to see new spikes

	private float slowestFrame = 0.00001f;  // Should probably use some math positive min thingy...
	private int frameCounter = 0;

	void Start()
	{
	    Application.targetFrameRate = 60;
	}
	 
	void OnGUI()
	{
		// I know this is a very lame but I was lazy
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