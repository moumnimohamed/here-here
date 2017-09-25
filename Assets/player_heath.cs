using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class player_heath : MonoBehaviour {

public GameObject effect_pos;
    public GameObject  dead_effect;
    public string   MY_TAG;
	// Use this for initialization
	void Start () {
		MY_TAG =this.gameObject.tag;
	}
	
	/// <summary>
	/// Sent when another object enters a trigger collider attached to this
	/// object (2D physics only).
	/// </summary>
	/// <param name="other">The other Collider2D involved in this collision.</param>
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "platform" || other.tag == "win")
			return;
		if(other.tag == this.gameObject.tag){
			return;
		}else{
			Instantiate(dead_effect,effect_pos.transform.position,Quaternion.identity);	
		Destroy(this.gameObject);
		}
	}

	
}
