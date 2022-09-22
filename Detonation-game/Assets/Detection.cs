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
    
private GameObject player;
    // Start is called before the first frame update
    void Start(){
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update() {

    if ((player.transform.position-this.transform.position).sqrMagnitude < 2*2) {
            Debug.Log("<color=red>Error: </color>");
        }     
    }
}
