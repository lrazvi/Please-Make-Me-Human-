using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingBehavior : MonoBehaviour
{
    public GameObject Ending;

    // Start is called before the first frame update
    void Start()
    {
        Ending.SetActive(false);
    }
}
