using UnityEngine;
using System.Collections;

public class FlapController : MonoBehaviour {
    public float hSpeed;
    public float vSpeed;
    public float gravity;
    public float terminalVelocity;
    public float fade;

    private TextMesh text;
    // Use this for initialization
    void Start () {
        text=GetComponent<TextMesh>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Level1Controller.dead) {
            return;
        }

        vSpeed = Mathf.Max(-terminalVelocity, vSpeed - gravity);
        transform.Translate(hSpeed, vSpeed, 0);

        text.color = new Color(text.color.r, text.color.g, text.color.b, Mathf.Max(0, text.color.a - fade));

        if (text.color.a == 0) {
            Destroy(gameObject);
        }
    }
}
