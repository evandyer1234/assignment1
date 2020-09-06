using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{
    NavMeshAgent myNavMeshAgent;
    
    
    void Awake()
    {
        myNavMeshAgent = GetComponent<NavMeshAgent>();
        myNavMeshAgent.SetDestination(new Vector3(0, 0, 0));
    }
    public void Target(Vector3 target)
    {
        myNavMeshAgent.SetDestination(target);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bad")
        {
            Destroy(gameObject);
        }
    }

    
    void Update()
    {
        
    }
}
