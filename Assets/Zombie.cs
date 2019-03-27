﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour {

    public NavMeshAgent agent;
    void Start() {
        agent = GetComponent<NavMeshAgent>();
    }


    void Update() {
        agent.SetDestination(GameObject.Find("thePlayer").transform.position);
    }
}
