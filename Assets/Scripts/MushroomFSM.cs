using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MushroomFSM : MonoBehaviour
{
    public enum EnemyState {GoToBase, AttackBase, ChasePlayer, AttackPlayer}

    public EnemyState currentState;
    public MushroomSight sightSensor;
    //public Transform baseTransform;
    public float baseAttackDistance;
    public float playerAttackDistance;
    public NavMeshAgent agent;
    public Animator anim;

    public GameObject mush;

    void Awake() {
        //baseTransform = GameObject.Find("BaseDamagePoint").transform;
        agent = mush.GetComponent<NavMeshAgent>();
        anim = mush.GetComponent<Animator>();
    
        
    }

    void GoToBase(){
        if(sightSensor.detectedObject != null){
            currentState = EnemyState.ChasePlayer;
        }
        // float distanceToBase = Vector3.Distance(transform.position, baseTransform.position);
        // if (distanceToBase <= baseAttackDistance){
        //     currentState = EnemyState.AttackBase;
        // }

    }
    void AttackBase(){
        print("AttackBase");
    }
    void ChasePlayer(){
        agent.isStopped = false;
        if(sightSensor.detectedObject == null){
            Debug.Log("hey");
            currentState = EnemyState.GoToBase;
            return;
        }
        else{
            //anim.SetBool("IsAttack", false);
            anim.SetFloat("Velocity", 5);
            agent.SetDestination(sightSensor.detectedObject.transform.position);
            float distanceToPlayer = Vector3.Distance(transform.position, sightSensor.detectedObject.transform.position);
            if(distanceToPlayer <= playerAttackDistance){
                currentState = EnemyState.AttackPlayer;
            }
        }
    }
    void AttackPlayer(){
        agent.isStopped = true;
        
        if(sightSensor.detectedObject == null){
            anim.SetFloat("Velocity", 0);
            //anim.SetBool("IsAttack", false);
            currentState = EnemyState.GoToBase;
            
        }

        //functiontoattack
        else{
            //anim.SetFloat("Velocity", 0);
            float distanceToPlayer = Vector3.Distance(transform.position, sightSensor.detectedObject.transform.position);
            anim.SetBool("IsAttack", true);
            if(distanceToPlayer > playerAttackDistance * 1.1f){
                currentState = EnemyState.ChasePlayer;
            }
        }
    }

    void OnDrawGizmos() {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, playerAttackDistance);

        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, baseAttackDistance);
    }


    void Update()
    {
        if (currentState == EnemyState.GoToBase){
            GoToBase();
        }
        else if(currentState == EnemyState.AttackBase){
            AttackBase();
        }
        else if(currentState == EnemyState.ChasePlayer){
            ChasePlayer();
        }
        else if(currentState == EnemyState.AttackPlayer){
            AttackPlayer();
        }
        
    }
}
