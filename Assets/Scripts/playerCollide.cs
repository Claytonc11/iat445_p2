using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollide : MonoBehaviour
{
  
     void OnCollisionEnter(Collision col){
        if(col.gameObject.name == "FPSController"){
            Destroy(gameObject);
            Debug.Log ("Hay is gone");
        }
     
    }
}
