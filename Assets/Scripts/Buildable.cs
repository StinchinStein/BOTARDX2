using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cakeslice;

public class Buildable : MonoBehaviour {
   
    private void OnMouseEnter() {
        Debug.Log("Mouse entered");
        transform.Find("Cube").GetComponent<Outline>().eraseRenderer = false;
    }
    private void OnMouseExit() {
        transform.Find("Cube").GetComponent<Outline>().eraseRenderer = true;
    }

}