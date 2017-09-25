using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using CnControls;

public class startbutton : MonoBehaviour {

	/// <summary>
	/// Update is called every frame, if the MonoBehaviour is enabled.
	/// </summary>
	void Update()
	{
		if(CnInputManager.GetButtonDown("Jump")){
			 SceneManager.LoadScene(1);
		}
	}
}
