using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load_next_scene : MonoBehaviour {

	// Use this for initialization
	public GameObject player ;
public	static int level_nbr =2;
	void Start () {
		player = GameObject.Find("player_shiiibi_1");
	}
	
	/// <summary>
	/// Update is called every frame, if the MonoBehaviour is enabled.
	/// </summary>
	void Update()
	{
		if(player==null)
		StartCoroutine(loadscene());
	}
	/// <summary>
	/// Sent when another object enters a trigger collider attached to this
	/// object (2D physics only).
	/// </summary>
	/// <param name="other">The other Collider2D involved in this collision.</param>
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag=="3oz" || other.tag=="bleu"){
               StartCoroutine(loadscene_win_state());
	}
}

	IEnumerator loadscene_win_state (){
          yield return new WaitForSeconds(0.5f);
		  SceneManager.LoadScene(level_nbr);
		  level_nbr =1+level_nbr;
if(level_nbr>5){
		  SceneManager.LoadScene(0);
		  level_nbr=2;
}
			}

	IEnumerator loadscene (){
          yield return new WaitForSeconds(0.5f);
          //SceneManager.LoadScene(load_next_scene.level_nbr);
		   int scene = SceneManager.GetActiveScene().buildIndex;
         SceneManager.LoadScene(scene, LoadSceneMode.Single);
	}
}
