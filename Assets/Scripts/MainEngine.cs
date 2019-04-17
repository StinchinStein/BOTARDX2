using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainEngine : MonoBehaviour
{
    public static MainEngine S;
    public static int currentRound = 0;
    public int zombiesPerRound = 5;
    public int[] maxZPerRound = new int[] { 5, 10, 15, 20 };
    public int zombiesSpawned = 0;
    public int runTicks = 0;

    void Start() {
        S = this;
    }

    private void Update() {
        runTicks++;
    }


}
