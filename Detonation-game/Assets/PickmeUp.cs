using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickmeUp : MonoBehaviour
{
    public Transform player;
    public Transform Flag;
    // private PlayerMovement playerscript;
    // public PlayerMovement maxflag;
    // Start is called before the first frame update
    void Start()
    {
        // playerscript = GetComponent<PlayerMovement>();
        // maxflag = playerscript.Maxflags;
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKeyDown(KeyCode.Space)){
        //     if(player.transform.position == Flag.transform.position){
        //         Debug.Log(playerscript.Maxflags);
        //         // playerscript.Maxflags--;
        //         // Destroy(Flag);
        //     }
        // }
    }
}
