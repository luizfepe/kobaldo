using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour
{
    public static float moveSpeed = 4;
    public static float jumpPower = 10;


    // Use this for initialization
    void Start()
    {

    }

    void FixedUpdate()
    {
        Movement();
    }

    // Update is called once per frame
    void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * jumpPower * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
    }
}

