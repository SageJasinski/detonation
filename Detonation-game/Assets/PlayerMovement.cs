using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform movePoint;

    public LayerMask whatStopsmovement;
    void Start(){

        movePoint.parent = null;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

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
    }
}
