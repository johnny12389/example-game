using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class monster1 : MonoBehaviour
{
    public float speed;
    public float sprint;
    public float stamina;
    public bool facingRight;
    private Rigidbody2D rb;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    public void Update()
    {
        if (Input.GetAxisRaw("Horizontal") < 0.5f || Input.GetAxisRaw("Horizontal") > -0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, 0f, 0f));
            if (Input.GetAxisRaw("Horizontal") < -0.5f && !facingRight)
            {
                //If we're moving right but not facing right, flip the sprite and set facingRight to true.
                Flip();
                facingRight = true;
                
            }
            else if (Input.GetAxisRaw("Horizontal") > 0.5f && facingRight)
            {
                //If we're moving left but not facing left, flip the sprite and set facingRight to false.
                Flip();
                facingRight = false;
                
            }

            //If we're not moving horizontally, check for vertical movement. The "else if" stops diagonal movement. Change to "if" to allow diagonal movement.
        }
        if(Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * speed * Time.deltaTime, 0f));
        }
        

        void Flip()
        {
            // Switch the way the player is labelled as facing
            facingRight = !facingRight;

            // Multiply the player's x local scale by -1
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }



        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * sprint * Time.deltaTime, 0f, 0f));
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }


       

    }
}
