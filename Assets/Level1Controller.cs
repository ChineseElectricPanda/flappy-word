using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class Level1Controller : MonoBehaviour {
    public GameObject player;
    public TextMesh playerText;
    public BoxCollider playerCollider;

    public static bool dead = false;

    // Use this for initialization
    void Start() {
        //Set the player text
        if (MainMenuController.PlayerName != null && MainMenuController.PlayerName.Trim().Length > 0) {
            playerText.text = MainMenuController.PlayerName;
        } else {
            playerText.text = "Player";
        }

        //Find the size of the player text
        Bounds bound = playerText.GetComponent<Renderer>().bounds;

        //Set the size of the hitbox
        playerCollider.size = new Vector3(bound.size.x, bound.size.y, 10);

    }

    // Update is called once per frame
    void Update() {
        if (dead && Input.GetKeyDown(KeyCode.Space)) {
            dead = false;
            SceneManager.LoadScene("Level1");
        }
        if (dead) {
            //Check for new touch
            foreach (Touch touch in Input.touches) {
                if (touch.phase == TouchPhase.Began) {
                    dead = false;
                    SceneManager.LoadScene("Level1");
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape)) {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
