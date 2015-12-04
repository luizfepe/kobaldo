using UnityEngine;
using System.Collections;

public class Ps : MonoBehaviour
{
    public float speed = 30;

    public string axis = "Vertical";

    void FixedUpdate()
        {
            float v = Input.GetAxisRaw(axis);
            GetComponent<Rigidbody>().velocity = new Vector3(0,0, v) * speed;
        }
    }
