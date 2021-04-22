using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiControl : MonoBehaviour
{
    public NavMeshAgent agent;
        
      void  Start ()
      {
        agent= this.GetComponent<NavMeshAgent>(); //Determina que os agents sigam a rota do navmesh
      }
}
