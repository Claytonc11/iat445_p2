using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objCollide : MonoBehaviour
{

    void OnCollisionEnter(Collision col){
        if(col.gameObject.name == "rock"){
             Debug.Log ("Rock is gone");
             Destroy(col.gameObject);
        }
    }
}
