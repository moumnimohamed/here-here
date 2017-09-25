using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class dead_zone : MonoBehaviour {

	public GameObject player;
	void Start () {
		
	}
	
	// Update is called once per frame
void OnTriggerEnter2D(Collider2D other)
{
	 loadscene();
}

	IEnumerator loadscene (){
          yield return new WaitForSeconds(0.5f);
          //SceneManager.LoadScene(load_next_scene.level_nbr);
		   int scene = SceneManager.GetActiveScene().buildIndex;
         SceneManager.LoadScene(scene, LoadSceneMode.Single);
	}
}
