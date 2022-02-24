using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    private GameObject[] goalLocations;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        goalLocations = GameObject.FindGameObjectsWithTag("NavGoal");
        agent = this.GetComponent<NavMeshAgent>();
        agent.SetDestination(goalLocations[Random.Range(0,goalLocations.Length)].transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (agent.remainingDistance <= 5 && Random.Range(0,99) == 0)
        {
            agent.SetDestination(goalLocations[Random.Range(0,goalLocations.Length)].transform.position);
        }
    }
}
