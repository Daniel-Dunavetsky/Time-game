using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;
    private Rigidbody2D rb;


    //variables for animation
    private Animation anim;
    public bool walkingRightCheck;
    public bool walkingLeftCheck;

    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    private void Update()
    {
        //Inputs
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        movingLeft();
        
    }

    private void movingLeft()
    {
        if (movement.x > 0)
        {
            
            walkingLeftCheck = true;
            anim.Play("waking left");
        }
    }

}
