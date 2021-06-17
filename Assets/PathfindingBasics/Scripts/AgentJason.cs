using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class AgentJason : MonoBehaviour
{
    private NavMeshAgent agent;
    private Waypoint1[] waypoints;

    private Waypoint1 RandomPoint => waypoints[Random.Range(0, waypoints.Length)];

    // Start is called before the first frame update
    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
        // FindOfObjectsOfType gets every instance of this component in the scene
        waypoints = FindObjectsOfType<Waypoint1>();

        // Tell the agent to move to a random position in the scene waypoints
        agent.SetDestination(RandomPoint.Position);
    }

    // Update is called once per frame
    void Update()
    {
        // Has the agent reached it's position?
        if (!agent.pathPending && agent.remainingDistance == 0)
        {
            // Tell the agent to move to a random position in the scene waypoints
            agent.SetDestination(RandomPoint.Position);
        }
    }
}
