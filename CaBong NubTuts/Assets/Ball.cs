using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
    public float speed = 30;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
	}

}
