 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour {

    public NavMeshAgent agent;
    public GameObject currentTarget;
    public NavMeshPath path;
    void Start() {
        agent = GetComponent<NavMeshAgent>();
    }


    void Update() {
        path = new NavMeshPath();
        agent.isStopped = false;
        currentTarget = GameObject.Find("thePlayer");
        float distance = Vector3.Distance(agent.transform.position, currentTarget.transform.position);

        agent.CalculatePath(GameObject.Find("thePlayer").transform.position, path);
        if (path.status == NavMeshPathStatus.PathPartial) {
            GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag("Obstacle");
            for (int i = 0; i < taggedObjects.Length; i++) {
                if (Vector3.Distance(currentTarget.transform.position, taggedObjects[i].transform.position) < 5) {
                    currentTarget = taggedObjects[i];
                }
            }
        }
        if (currentTarget != null) {
            if (distance > 1) {
                agent.SetDestination(currentTarget.transform.position);
            } else {
                agent.isStopped = true;
            }
        }
    }
}
