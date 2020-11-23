using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {
    [SerializeField] private float _moveSpeed = 10f;


    void Update() {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        if (horizontal != 0) {
            transform.Translate(Vector3.right * horizontal * _moveSpeed * Time.deltaTime);
        }

        if (vertical != 0) {
            transform.Translate(Vector3.up * vertical * _moveSpeed * Time.deltaTime);
        }
    }
}
