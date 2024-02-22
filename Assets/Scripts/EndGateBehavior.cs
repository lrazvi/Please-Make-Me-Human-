using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGateBehavior : MonoBehaviour
{
    GameObject PlayerStats;
    public float targetSouls;
    public GameObject GateError;
    public GameObject EndText;

    void OnCollisionEnter(Collision collision)
    {
        PlayerStats = GameObject.Find("PlayerStats");
        //Debug.Log(PlayerStats.soulCount);

        if(collision.gameObject && PlayerStats.GetComponent<FrogStats>().soulCount >= targetSouls)
            {
                
                EndText.SetActive(true);
                Time.timeScale = 0f;
            }
        else
            {
                GateError.SetActive(true);
            }
    }

    void OnCollisionExit(Collision collision)
    {
        GateError.SetActive(false);
    }
}