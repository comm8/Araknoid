using UnityEngine;
using System.Collections;

public class Racket : MonoBehaviour
 {

    public float speed = 150;
    //Movement Speed

    void FixedUpdate()
    {
    float h = Input.GetAxisRaw("Horizontal");
    //A-D input

    GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;
    // Set Velocity (movement direction * speed)

    }
 }