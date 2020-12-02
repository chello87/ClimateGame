using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlanet : MonoBehaviour
{
    [SerializeField] private GameObject _globe = null;
    
    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        transform.Rotate(0, yInput, 0, Space.World);
        _globe.transform.Rotate(xInput, 0, 0, Space.World);
    }
}
