using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMushroom : MonoBehaviour
{
    public float damage;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Tongue"){
            Debug.Log("Collision Detected");
            Destroy (this.transform.gameObject);
        }
    }
    // void Update(){

    // }
}
