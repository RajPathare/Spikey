    using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMovement : objMovement
{

    [SerializeField] private float jumpPower = 2.288f;
    [SerializeField] private float gravityVal = -0.3f;
    [SerializeField] private float jumpAirPower = 0.5f;
    [SerializeField] private bool isGrounded;
    [SerializeField] public static bool isGameOver;

   


    void Start()
    {
        
        isGameOver = false;
        Physics2D.gravity = new Vector2(Physics2D.gravity.x, gravityVal);
        rb = GetComponent<Rigidbody2D>();
    
        speed = 3.5f;
        direction = 1;
       
        
        Destroy(GetComponent<PolygonCollider2D>());
        gameObject.AddComponent<PolygonCollider2D>();



        rb.velocity = new Vector2(speed * direction, rb.velocity.y);


    }


   /* private void Update()
    {
        DirectionChange();
        hmm();
        

    }*/

     private void Update()
    {
        DirectionChange();
        /*if ((Input.GetKeyDown("space") || Input.touchCount > 0) && !isGameOver)
        {
            Jump();

        }*/

         if (Input.GetKeyDown("space") && !isGameOver)
        {
            Jump();

        }
        

        //EXPERIMENTAL
       /* if (rb.velocity.y < 0f)
		{
			rb.AddForce(new Vector2(0, -0.4f), ForceMode2D.Impulse);
		}*/
        //Debug.Log(rb.velocity);

    }


   /* public void hmm(){


    	if ((Input.GetKeyDown("space") || Input.touchCount == 1) && !isGameOver)
        {
           
            rb.AddForce(new Vector2(0, jumpPower), ForceMode2D.Impulse);

        }
    }*/

      private void Jump()
    {
        Debug.Log("hmm");
            rb.AddForce(new Vector2(0, jumpPower) , ForceMode2D.Impulse);
            
        

        /*if (rb.velocity.y >= 2f && rb.velocity.y <= 4f)
        {
            rb.AddForce(new Vector2(0, jumpAirPower), ForceMode2D.Impulse);
        }*/


    }

    public void andrjump(){

        rb.AddForce(new Vector2(0, jumpPower) , ForceMode2D.Impulse);

    }

   


}

