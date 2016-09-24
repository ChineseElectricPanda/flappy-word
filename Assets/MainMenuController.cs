using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour {

    public static string PlayerName;

    public Text inputField;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void StartGame() {
        PlayerName = inputField.text;
        if (PlayerName == null || PlayerName.Trim().Length == 0) {
            PlayerName = "Word";
        }
        SceneManager.LoadScene("Level1");
    }
}
