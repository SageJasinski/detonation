using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardinalDetonation : MonoBehaviour
{
    private bool Detection = false;
    public GameObject Player;
    public GameObject Cardinal;
    private Vector3 Distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Distance = Player.transform.position-Cardinal.transform.position;
        float mag = Distance.magnitude;
        //when the player is one square away from the blast radiouse zone then do this
        if(mag < 2f){
            Debug.Log("BEEP BEEP");
        }

        //Reun damage and any other things to happen when player is close to the mine and in the blast radiouse
        if(Detection == true){
            Debug.Log("Explosion zone");
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "Player"){
            Detection = true;
        }

    }
    private void OnTriggerExit2D(Collider2D collision){
        if(collision.gameObject.tag == "Player"){
            Detection = false;
        }
    }
}
