using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AgentSmith : MonoBehaviour
{
    private NavMeshAgent agent;
    private Waypoint[] waypoints;

    public Animator anim;

    private Waypoint RandomPoint => waypoints[Random.Range(0, waypoints.Length)];

    // Start is called before the first frame update
    void Start()
    {
        // Grab the component NavMeshAgent
        agent = gameObject.GetComponent<NavMeshAgent>();
        // FindOfObjectsOfType gets every instance of this component in the scene
        waypoints = FindObjectsOfType<Waypoint>();
        // Tell the agent to move to a random position in the scene waypoints
        agent.SetDestination(RandomPoint.Position);
        // 
        anim = GetComponent<Animator>();
        anim.SetBool("walk1", true);
    }

    // Update is called once per frame
    void Update()
    {
        // Has the agent reached it's position?
        if(!agent.pathPending && agent.remainingDistance == 0)
        {
            // Tell the agent to move to a random position in the scene waypoints
            agent.SetDestination(RandomPoint.Position);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "way1":
                {
                    anim.SetBool("wa1k", false);
                }
                break;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        anim.SetBool("walk1", false);
    }
}
