using UnityEngine;
using System.Collections;

public class Racket : MonoBehaviour
 {

    public float speed = 150;
    public Transform Cam;
    public Vector3 offset;
    //Movement Speed

private void Update() {
   Cam.position = Vector3.Lerp(Cam.position, this.transform.position + offset, 0.2f * Time.deltaTime);
}


    void FixedUpdate()
    {
    float h = Input.GetAxisRaw("Horizontal");
    //A-D input

    GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;
    // Set Velocity (movement direction * speed)

    }
 }