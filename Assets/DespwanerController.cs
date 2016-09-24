using UnityEngine;
using System.Collections;

public class DespwanerController : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Obstacle") {
            Destroy(other.gameObject);
        }

    }
}
