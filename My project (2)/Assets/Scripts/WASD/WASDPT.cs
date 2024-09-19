using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDPT : MonoBehaviour
{
    //Variables
    public float movespeed = 5f;

    private Rigidbody2D rb;
    private Vector2 movement;



    // Start is called before the first frame update
    void Start()
    {
        //Finds the component of your object
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Get Input from IJKL
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        //Movement object
        movement = new Vector2(moveX, moveY).normalized;

    }

    //This is the update called on a fixed value of frames
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movespeed * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        
    }
}
