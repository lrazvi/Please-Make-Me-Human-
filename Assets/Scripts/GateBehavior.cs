using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GateBehavior : MonoBehaviour
{
    GameObject PlayerStats;
    public string targetScene;
    public float targetSouls;
    public GameObject GateError;

    void OnCollisionEnter(Collision collision)
    {
        PlayerStats = GameObject.Find("PlayerStats");
        //Debug.Log(PlayerStats.soulCount);

        if(collision.gameObject && PlayerStats.GetComponent<FrogStats>().soulCount >= targetSouls)
            {
                SceneManager.LoadScene(targetScene);
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