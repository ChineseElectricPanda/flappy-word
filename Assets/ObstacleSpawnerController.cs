using UnityEngine;
using System.Collections;

public class ObstacleSpawnerController : MonoBehaviour {
    public int spawnFrequency;
    public GameObject obstacle;
    public float minHeight, maxHeight;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Level1Controller.dead) {
            return;
        }

        if (Time.frameCount % spawnFrequency == 0) {
            Instantiate(obstacle, new Vector3(transform.position.x, Random.Range(minHeight, maxHeight)), new Quaternion());
        }
	}


}
