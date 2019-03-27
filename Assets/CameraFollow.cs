using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    [SerializeField] private GameObject playerTrack;
    public float distance = 6f;
    private float zoom = 0;
    [SerializeField] private float offX = 0;
    [SerializeField] private float offY = 0;
    void Start() {
        
    }

    void Update() {
        if (Input.GetAxis("Mouse ScrollWheel") > 0) {
            zoom -= 0.5f;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0) {
            zoom += 0.5f;
        }
    }
    void LateUpdate() {
        transform.position = Vector3.Lerp(transform.position, playerTrack.transform.position + new Vector3(offX, distance + zoom, offY), 12f * Time.deltaTime);
        //transform.LookAt(playerTrack.transform);
    }
}
