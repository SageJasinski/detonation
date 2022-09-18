using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagCounter : MonoBehaviour{

    public UnityEngine.UI.Text Count;
     int Max = 5;
        // Start is called before the first frame update
        void Start()
        {
            Count.text = Max.ToString();
        }

        // Update is called once per frame
        void Update()
        {
            if(Max > 0){
                if(Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Q)){
                    Max--;
                    Count.text = Max.ToString();
                }
            }

            if(Input.GetKeyDown(KeyCode.Space) && Max < 5){
                Max++;
                Count.text = Max.ToString();
            }
        }
}