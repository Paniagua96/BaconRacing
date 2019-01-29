using UnityEngine;
using System.Collections;

public class pruebaMovCubo : MonoBehaviour
{
    public Countdown countdown;


    public float speed;

    private Rigidbody rb;

    void Start()
    {
        countdown = FindObjectOfType<Countdown>();
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {

        if (countdown.movement == true)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            rb.AddForce(movement * speed);
        }
      
    }
}