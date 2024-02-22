using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public GameObject PlayerStats;
    public GameObject Health1;
    public GameObject Health2;
    public GameObject Health3;
    public GameObject Health4;

    public GameObject GameOver;

    public MushroomSight sightSensor;
    public Animator anim;

    void Start() {
        //anim = mush.GetComponent<Animator>();

        Health1 = GameObject.Find("Health"); 
        Health2 = GameObject.Find("Health (1)"); 
        Health3 = GameObject.Find("Health (2)"); 
        Health4 = GameObject.Find("Health (3)"); 
    }

    void Update()
    {
        Heal();
        //Damage(mush);
        EndState();
    }

    void Heal()
    {
        // if (Input.GetKeyDown(KeyCode.H))
        // {
        //     if(PlayerStats.GetComponent<FrogStats>().playerHealth < 4)
        //     {
        //         PlayerStats.GetComponent<FrogStats>().playerHealth += 1;
        //         Debug.Log(PlayerStats.GetComponent<FrogStats>().playerHealth);
        //     }
        // }
    }


    // void Damage(GameObject other)
    // {
    //     //if (Input.GetKeyDown(KeyCode.G))
    //     //float distanceToPlayer = Vector3.Distance(transform.position, sightSensor.detectedObject.transform.position);
    //     // if(Vector3.Distance(transform.position, other.transform.position) == 3 )
    //     // {
    //     //     if(PlayerStats.GetComponent<FrogStats>().playerHealth > 0)
    //     //     {
    //     //         PlayerStats.GetComponent<FrogStats>().playerHealth -= 1;
    //     //         Debug.Log(PlayerStats.GetComponent<FrogStats>().playerHealth);
    //     //     }
    //     // }

    // }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Mushroom"){
            Debug.Log(PlayerStats.GetComponent<FrogStats>().playerHealth);
            if(PlayerStats.GetComponent<FrogStats>().playerHealth > 0)
            {
                PlayerStats.GetComponent<FrogStats>().playerHealth -= 1;
                if(PlayerStats.GetComponent<FrogStats>().playerHealth == 3){
                    Destroy(Health4);
                }
                else if(PlayerStats.GetComponent<FrogStats>().playerHealth == 2){
                    Destroy(Health3);
                }
                else if(PlayerStats.GetComponent<FrogStats>().playerHealth == 1){
                    Destroy(Health2);
                }
                if(PlayerStats.GetComponent<FrogStats>().playerHealth == 0){
                    Destroy(Health1);
                }

                    
            }
        }
        
    }

    void EndState()
    {
        if(PlayerStats.GetComponent<FrogStats>().playerHealth == 0)
        {
            GameOver.SetActive(true);
            Time.timeScale = 0f;
        } 
    }
}
