using UnityEngine;
using System.Collections;
using CnControls;

public class player_move : MonoBehaviour
{

    public AudioSource audi;
	public AudioClip  switsh_color;
    public Animator anime;
   
	public	GameObject smok;
	public Transform smokposition;

	 public float maxSpeed;


    public Rigidbody2D body2d;
   
    
    public bool facingright = true;
    // Use this for initialization


   

    void Start()
    {
       audi =GetComponent<AudioSource>();
        body2d = GetComponent<Rigidbody2D>();
        anime = GetComponent<Animator>();

    }



    // Update is called once per frame
    void Update()
    {

    }



public float slideVelocity = -5f;
	public GameObject dustPrefab;
	public float dustSpawnDelay = .5f;

	private float timeElapsed = 0f;

	public GameObject slid_position;

	void FixedUpdate () {



		float hor = CnInputManager.GetAxis ("Horizontal");
		

			timeElapsed += Time.deltaTime;
		
		anime.SetFloat ("animstate", Mathf.Abs (hor));
		body2d.velocity = new Vector2 (hor * maxSpeed, body2d.velocity.y);
	
	  if(hor!=0){
		  if(timeElapsed > dustSpawnDelay){


            
				var dust = Instantiate(dustPrefab,slid_position.transform.position,Quaternion.identity);
				//var pos = transform.position;
				//pos.y += 2;
                 dust.transform.eulerAngles = new Vector3(0, 0, -90);
				Vector3 mysscale= transform.localScale;
				dust.transform.localScale = new Vector3(1f,mysscale.x*-1f,1f);
				timeElapsed = 0;

			}
	  }

		

		if ((hor > 0 && !facingright)||(hor < 0 && facingright) )
			Flip ();


      if (CnInputManager.GetButtonDown("Jump")){

        if(  this.gameObject.tag=="bleu"){
		  audi.PlayOneShot(switsh_color);			
		  anime.SetInteger("switsh",1);
		  this.gameObject.tag="3oz";
		}else{
		  audi.PlayOneShot(switsh_color);			
			 anime.SetInteger("switsh",0);
		  this.gameObject.tag="bleu";
		}
	  }
		}


	public void Flip()
	{
		facingright = !facingright;
		Vector3 myScale = transform.localScale;
		myScale.x *= -1;
		transform.localScale = myScale;

		
	}
    void OnTriggerEnter2D(Collider2D coll)
    {
       
    }


	public void play_clip_run (){
		audi.Play();
	}
/*	public void Smok (){
			var smoks = Instantiate (smok, smokposition.position, Quaternion.identity)as GameObject;
			smoks.transform.localScale = transform.localScale;
	}*/
}
