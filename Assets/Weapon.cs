using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item {

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private LayerMask layerMask;
    void Start() {}
    void Update() {
        
        Ray r = Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f));
        RaycastHit hit;
        if (Physics.Raycast(r, out hit, layerMask)) {
            if (Input.GetMouseButtonDown(1)) {
                Instantiate(bulletPrefab, hit.point, Quaternion.identity);
            }
        }
    }

}
