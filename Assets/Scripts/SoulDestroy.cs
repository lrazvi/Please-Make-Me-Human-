using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulDestroy : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Frog_LOD0")
        {
            Destroy(this.transform.gameObject);
            Debug.Log("Soul collected.");
        }
    }
}
