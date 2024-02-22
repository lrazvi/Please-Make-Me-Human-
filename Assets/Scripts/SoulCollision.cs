using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulCollision : MonoBehaviour
{
    public GameObject PlayerStats;
    public AudioSource sound;
    
    void OnCollisionEnter(Collision collision)
    {
        //PlayerStats = GameObject.Find("PlayerStats");
        sound = GetComponent<AudioSource>();

        if(collision.gameObject.name == "TempSoul")
        {
            PlayerStats.GetComponent<FrogStats>().soulCount += 1;
            Debug.Log(PlayerStats.GetComponent<FrogStats>().soulCount);
            sound.Play();
        }
    }
}
