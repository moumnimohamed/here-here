using UnityEngine;
using System.Collections;

public class screenFader : MonoBehaviour {


	Animator anim;
	bool isfading=false;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void AnimationComplet () {
		isfading = false;
	
	}
	public IEnumerator FadetoClear (){
		isfading = true;
		anim.SetTrigger ("fadeIN");
		while (isfading)
			yield return null;
	}
	public IEnumerator FadetoBlack (){
		isfading = true;
		anim.SetTrigger ("fadeOUT");
		while (isfading)
			yield return null;
	}


}
