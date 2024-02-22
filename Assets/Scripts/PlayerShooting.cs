using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject prefab;
    public GameObject ShootPoint;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject clone = Instantiate(prefab);
            GameObject shoot = Instantiate(ShootPoint);
            clone.transform.position = ShootPoint.transform.position;
            clone.transform.rotation = ShootPoint.transform.rotation;
            shoot.transform.position = ShootPoint.transform.position;
            shoot.transform.rotation = ShootPoint.transform.rotation;
            //Instantiate(prefab, transform.position, transform.rotation);
            //Instantiate(ShootPoint, transform.position, transform.rotation);
        }
    }
}
