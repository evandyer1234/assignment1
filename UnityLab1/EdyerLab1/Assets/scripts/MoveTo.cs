using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : CommandBase
{
    public Vector3 startpos;
    public Vector3 endpos;
    public agent guy;

    
    public override void Execute()
    {
        guy.myNavMeshAgent.SetDestination(gameObject.transform.position);
        if (guy.myNavMeshAgent.remainingDistance <= guy.distance)
        {
            Complete();
        }
    }
    public override void Complete()
    {
        guy.Next();
    }
}
