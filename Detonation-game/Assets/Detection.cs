using System.Globalization;
// using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Linq.Expressions;
// using System.Reflection.PortableExecutable;
// using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour {

public GameObject Cardinal;

public GameObject Corner;
    
// private GameObject player;
    // Start is called before the first frame update
    void Start(){
        // player = GameObject.Find("Player");

        //puts out cardinal direction detectors refrenced at the mine
        Instantiate(Cardinal, transform.position + new Vector3(+1,0), Quaternion.identity);

        Instantiate(Cardinal, transform.position + new Vector3(-1,0), Quaternion.identity);

        Instantiate(Cardinal, transform.position + new Vector3(0,+ 1), Quaternion.identity);

        Instantiate(Cardinal, transform.position + new Vector3(0,-1), Quaternion.identity);

        //puts out the corner detectors based on where mine is placed
        Instantiate(Corner, transform.position + new Vector3(+1,+1), Quaternion.identity);

        Instantiate(Corner, transform.position + new Vector3(+1,-1), Quaternion.identity);

        Instantiate(Corner, transform.position + new Vector3(-1,+1), Quaternion.identity);

        Instantiate(Corner, transform.position + new Vector3(-1,-1), Quaternion.identity);
    }

    // Update is called once per frame
    void Update() {

    // if ((player.transform.position-this.transform.position).sqrMagnitude < 2*2) {
    //         Debug.Log("<color=red>Error: </color>");
    //     }     
    }
}
