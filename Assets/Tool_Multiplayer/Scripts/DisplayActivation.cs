﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayActivation : MonoBehaviour {

	void Start()
	{
		Debug.Log ("Display connected: " + Display.displays.Length);
		if (Display.displays.Length > 1)
			Display.displays [1].Activate ();

		if (Display.displays.Length > 2)
			Display.displays [2].Activate ();
	}
}
