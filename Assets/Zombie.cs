using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour {

    public NavMeshAgent agent;
    void Start() {
        agent = GetComponent<NavMeshAgent>();
    }


    void Update() {
        agent.isStopped = false;
        float distance = Vector3.Distance(agent.transform.position, GameObject.Find("thePlayer").transform.position);

        if (distance > 1) {
            agent.SetDestination(GameObject.Find("thePlayer").transform.position);
        } else {
            agent.isStopped = true;
        }
    }
}
