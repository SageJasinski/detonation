using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform movePoint;

    public LayerMask whatStopsmovement;

    public GameObject Flag;
    public Transform FlagPos;
    public Transform player;
    private GameObject colid;

    public int Maxflags = 0;

    bool trigger = false;

    void Start(){

        movePoint.parent = null;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

            //Player movement on grid system
            if(Vector3.Distance(transform.position, movePoint.position) <= .05f){

            //gets input from user and decieds if its verticle or horizontile
            //Mathf.Abs will make it not negitive
            if(Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f){
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), .2f, whatStopsmovement)){

                movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                }
            }

            if(Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f){
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3( 0f,Input.GetAxisRaw("Vertical"), 0f), .2f, whatStopsmovement)){

                movePoint.position += new Vector3( 0f,Input.GetAxisRaw("Vertical"), 0f);
                }
            }
        }

        //This lets the player place a flag on a specific squar
        if(Maxflags <= 4){
            if(Input.GetKeyDown (KeyCode.E)){
                Instantiate(Flag, transform.position + new Vector3(+1,0), Quaternion.identity);
                Maxflags++;
                Debug.Log(Maxflags);
            }
            if(Input.GetKeyDown(KeyCode.Q)){
                Instantiate(Flag, transform.position + new Vector3(-1,0), Quaternion.identity);
                Maxflags++;
                Debug.Log(Maxflags);
            }
        }

        if(Input.GetKeyDown(KeyCode.Space) && trigger == true){
            Maxflags--;
            Destroy(colid);
        }
    }

    //creates collision instence with an obj
    private void OnTriggerEnter2D(Collider2D collision){
        //collision with Flag tag obj

        if(collision.gameObject.tag == "Flag"){
            trigger = true;

            colid = (collision.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision){
        if(collision.gameObject.tag == "Flag"){
            trigger = false;
        }
    }
}
