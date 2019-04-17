using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZSpawner : MonoBehaviour {

    public GameObject zombiePrefab;
    void Start() {
        //Invoke("SpawnZombie", 1.5f);
    }

    private void Update() {
        int maxZombies = MainEngine.S.maxZPerRound[MainEngine.currentRound];

        if(MainEngine.S.zombiesSpawned < maxZombies) {
            if(MainEngine.S.runTicks % 150 == 149) {
                SpawnZombie();
            }

        }
    }
    private void SpawnZombie() {
        GameObject spawner = GameObject.Find("ZombieSpawner");

        GameObject zombie = Instantiate<GameObject>(zombiePrefab);
        zombie.transform.position = spawner.transform.position;

        MainEngine.S.zombiesSpawned++;
    }
}
