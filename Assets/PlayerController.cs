using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    public GameObject flap;

    public TextMesh scoreTextMesh;
    public BoxCollider scoreTextCollider;

    public float gravity;
    public float terminalVelocity;
    public float jumpForce;

    public float vSpeed;

    public int score;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Level1Controller.dead) {
            return;
        }

        //Check for jump event
        if (Input.GetKeyDown(KeyCode.Space)) {
            vSpeed = jumpForce;
            Instantiate(flap, transform.position, new Quaternion());
        }else {
            vSpeed = Mathf.Max(-terminalVelocity, vSpeed - gravity);
        }

        transform.Translate(0, vSpeed, 0);

        //Update the size of the subtitle collider
        Bounds bound = scoreTextMesh.GetComponent<Renderer>().bounds;
        scoreTextCollider.size = new Vector3(bound.size.x, bound.size.y, 10);
	}

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Gap" && !other.transform.parent.GetComponent<ObstacleController>().triggered) {
            score++;
            scoreTextMesh.text = "Score: " + score;
            other.transform.parent.GetComponent<ObstacleController>().triggered = true;
            Destroy(other);
        }
        if (other.tag == "Wall") {
            Level1Controller.dead = true;
        }
    }
}
