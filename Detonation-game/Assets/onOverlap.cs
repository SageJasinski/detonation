using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onOverlap : MonoBehaviour
{

    private GameObject player;
    // public Transform Cardinal;
    // public Transform Player;
    // private int Zero;

    // Start is called before the first frame update
    void Start(){
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update(){

        // public boolean Equals(this.transform.position player.transform.position);

        if(Vector3.Equals(this.transform.position, player.transform.position) == true){
            Debug.Log("<color=red>Danger!</color>");
        }
    }
}
