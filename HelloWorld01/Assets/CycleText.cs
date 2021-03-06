﻿using UnityEngine;
using System.Collections.Generic;

public class CycleText : MonoBehaviour
{
	public List<string> locTexts = new List<string>();

	const int FLIP_TEXT_UPDATE_COUNT = 240;

	private int locTextIndex = 0;
	private int updateCount = 0;
	private SysFontText sft;
	
	void Start ()
	{
		sft = gameObject.GetComponent<SysFontText>();
	}
	
	void Update ()
	{
		if( updateCount == 0 || updateCount >= FLIP_TEXT_UPDATE_COUNT )
		{
			updateCount = 1;

			if( locTextIndex >= locTexts.Count )
				locTextIndex = 0;
				
			sft.Text = locTexts[ locTextIndex ];
			locTextIndex++;
		}
		updateCount++;
	}
}
