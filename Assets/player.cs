using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {

    public float moveSpeed = 0.1f;
    public KeyCode rightKey = KeyCode.RightArrow;
    public KeyCode leftKey = KeyCode.LeftArrow;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(rightKey))
        {
            transform.Translate(moveSpeed, 0, 0);
        }

        if (Input.GetKey(leftKey))
        {
            transform.Translate(-moveSpeed, 0, 0);
        }
        
        if (transform.position.y < -2.47 && gameObject.name == "eggplant")
        {
            SceneManager.LoadScene("game over");
        }

        if (transform.position.y < -2.47 && gameObject.name == "potato5")
        {
            SceneManager.LoadScene("eggwin");
        }
    }
}
