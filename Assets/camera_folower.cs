using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_folower : MonoBehaviour {



	Vector3 campos;
	Vector3 playerpos;
	// Use this for initialization
	
	
	// Update is called once per frame
    public Transform player_trans;
    public GameObject player;

    public float maxdistanceright = 1.5f;
    public float maxdistanceleft = 1.5f;
    public float maxdestanceup = .5f;
    public float maxdestancedown = .5f;

   
/// <summary>
/// Update is called every frame, if the MonoBehaviour is enabled.
/// </summary>


    void Start (){

        
        
    
}
   void LateUpdate ()
    {
        player = GameObject.Find("player_shiiibi_1");
        player_trans = player.transform;
        if (player != null)
        {

            Vector3 campos = transform.position;

            Vector3 playerpos = player_trans.position;


            if (playerpos.x - campos.x > maxdistanceright)
            {

                campos.x = playerpos.x - maxdistanceright;
            }
            else

                if (campos.x - playerpos.x > maxdistanceleft)
                {

                    campos.x = playerpos.x + maxdistanceleft;
                }



            if (playerpos.y - campos.y > maxdestanceup)
            {
                campos.y = playerpos.y - maxdestanceup;
            }
            else if (campos.y - playerpos.y > maxdestancedown)
            {
                campos.y = playerpos.y + maxdestancedown;
            }

           
            transform.position = campos;
        }
        else {

        }
    }


}
