using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Raycast : MonoBehaviour{
    [SerializeField] private Text _regionname = null;

    void Update() {
        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.forward * 999, Color.green);

        if (Physics.Raycast(transform.position, transform.forward, out hit, 999)) {
            if (hit.collider.gameObject.tag == "Region") {
                if (_regionname.text != hit.transform.name) {
                    _regionname.text = hit.transform.name;
                }
            }
            else {
                if(_regionname.text != "") {
                    _regionname.text = "";
                }
            }
        }
        else {
            if (_regionname.text != "") {
                _regionname.text = "";
            }
        }
    }
}
