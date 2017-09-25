using UnityEngine;
using System.Collections;

public class move__platform : MonoBehaviour {

    public float stoppos1;
    public float stoppos2;

    public float speed; 
	// Use this for initialization
	void Start () {
        speed = Random.Range(50f,200f);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector2(0, speed * Time.deltaTime));
       // transform.Translate(new Vector2(0f,  speed * Time.deltaTime));
        if (transform.position.y >=stoppos1)
        {
            transform.position = new Vector2(transform.position.x, stoppos1);
            speed = -speed;
      
         


        }
        else if (transform.position.y <= stoppos2)
        {
            transform.position = new Vector2(transform.position.x, stoppos2);
            speed = speed*-1;
              
        }
       
    }
}
