using UnityEngine;
using System.Collections;

public class RotateObject : MonoBehaviour
{
	private static string debugText = "Blah";
	private static int frameCount = 0;
	
	void Update()
	{
		transform.Rotate(Vector3.right * Time.deltaTime * 30.0f);
		transform.Rotate(Vector3.up * Time.deltaTime * 50.0f, Space.World);
	}

	void OnGUI()
	{
		frameCount++;
		
		if( ( frameCount % 100 ) == 0 )
			debugText += "1";

		// GUI.Label(new Rect( 0.0f, 0.0f, Screen.width, Screen.height ), debugText );
	}
}