using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shakeit : MonoBehaviour {

	/// <summary>
	/// Awake is called when the script instance is being loaded.
	/// </summary>
	void Awake()
	{
		            		shake_camera.Chacknow(0.2f,0.5f);			

	}
}
