using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayer : MonoBehaviour {

    public float moveSpeed = 1f;
    private Rigidbody body;
    private Camera cam;

    [SerializeField] private float floorDist = 1;
    private Vector3 moveInput;
    private Vector3 moveVelocity;
    private RaycastHit mouseHit;

    void Start() {
        body = GetComponent<Rigidbody>();
        cam = Camera.main;
    }
    
    void Update() {
        moveInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        moveVelocity = moveInput * moveSpeed;

        Vector3 mWP = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        Ray r = cam.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f));
        RaycastHit hit;
        if(Physics.Raycast(r, out hit)) {
            mouseHit = hit;
        }
        transform.LookAt(mouseHit.point);
        transform.rotation = Quaternion.Euler(new Vector3(0, transform.rotation.eulerAngles.y, 0));
        
    }

    private void OnDrawGizmos() {
        Gizmos.DrawLine(transform.position, mouseHit.point);
    }
    void FixedUpdate() {
        float yVel = body.velocity.y;
        if(IsGrounded()) {
            yVel -= 0.25f;
        }
        body.velocity = new Vector3(moveVelocity.x, yVel, moveVelocity.z);

    }


    private bool IsGrounded() {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, floorDist)) {
            Debug.DrawRay(transform.position, Vector3.down * floorDist, Color.yellow);
            return true;
        }

        return false;
    }
}
