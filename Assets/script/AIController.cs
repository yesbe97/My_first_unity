using UnityEngine;
using System.Collections;

public class AIController : MonoBehaviour {

    public Transform target;
    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void FixedUpdate()
    {
        agent.SetDestination(target.position);
    }
    
}
