using UnityEngine;
using System.Collections;

public class ObstacleController : MonoBehaviour {
    public float speed;

    public bool triggered=false;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Level1Controller.dead) {
            return;
        }

        transform.Translate(-speed, 0, 0);
    }
}
