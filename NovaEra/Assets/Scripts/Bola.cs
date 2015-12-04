using UnityEngine;
using System.Collections;

public class Bola : MonoBehaviour
{
    public float speed = 30;
    void Start()
    {
        GetComponent<Rigidbody>().velocity = Vector3.right * speed;
    }
}