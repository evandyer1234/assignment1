using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class agent : MonoBehaviour
{
    public NavMeshAgent myNavMeshAgent;

    public List<MoveTo> points = new List<MoveTo>();
    public int listindex = 0;
   
    public bool stop = true;
    public int cycle = 0;
    public float distance = 1f;

    void Start()
    {
        myNavMeshAgent = GetComponent<NavMeshAgent>();
        myNavMeshAgent.SetDestination(new Vector3(0, 0, 0));
    }
   
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (cycle + 1 != 3)
            {
                cycle++;              
            }
            else
            {
                cycle = 0;
            }       
        }
       if (points[listindex] != null && !stop)
       {
           
            points[listindex].Execute();
       }
    }
    public void Next()
    {
        if (cycle == 0 && points[listindex + 1] != null)
        {
            listindex++;
        }
        else if (cycle == 1 && points[listindex - 1] != null)
        {
            listindex--;
        }
        else
        {
            stop = true;
        }
    }
    public void Target(Vector3 spot)
    {
        myNavMeshAgent.SetDestination(spot);
    }
}
