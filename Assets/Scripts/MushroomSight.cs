using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomSight : MonoBehaviour
{
    public float distance;
    public float angle;
    public LayerMask objectLayers;
    public LayerMask obstacleLayers;

    public Collider detectedObject;

    

    void Update() {
        Collider[] colliders = Physics.OverlapSphere(transform.position, distance, objectLayers);

        detectedObject = null;
        for (int i = 0; i < colliders.Length; i++)
        {
            Collider collider = colliders[i];
            Vector3 directionToCollider = Vector3.Normalize(collider.bounds.center - transform.position);
            float angleToCollider = Vector3.Angle(transform.forward, directionToCollider);

            if (angleToCollider < angle){
                if(!Physics.Linecast(transform.position, collider.bounds.center, obstacleLayers)){
                    detectedObject = collider;
                    break;
                }
            }

        }
        
    }
}
