using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOverTime : MonoBehaviour {

    [SerializeField] float _hoursPerSecond = 1f;        
    private const float DEGREES_IN_HOUR = 15f;
    
    void Update() {
        transform.Rotate(Vector3.up, DEGREES_IN_HOUR * _hoursPerSecond * Time.deltaTime);
    }
}
