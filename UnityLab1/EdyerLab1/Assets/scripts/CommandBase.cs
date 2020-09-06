using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//I have it as a monobehavior so that it can read information from the NavMesh agent
public class CommandBase : MonoBehaviour
{
   
    public virtual void Execute()
    {

    }
    public virtual void Complete()
    {

    }
}
