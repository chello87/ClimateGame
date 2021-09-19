using UnityEngine;

public class RotatePlanet : MonoBehaviour {
    [SerializeField] private GameObject _globe;
    
    void Update() {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        transform.Rotate(0, yInput, 0, Space.World);
        _globe.transform.Rotate(xInput, 0, 0, Space.World);
    }
}
