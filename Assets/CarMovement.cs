using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    //variables
    public SpriteRenderer SR;
    public Rigidbody2D RB;
    public Collider2D Coll;
    public float Speed = 10;

    public int Health = 15;

    // gonna implement to see if it changes the way the sprite changes/facing
    public bool FacingLeft = false;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vel = RB.velocity;


        if (Input.GetKey(KeyCode.UpArrow))
        {
            vel.y = Speed;
        }
        else
        {
            vel.y = 0;
        }

        // movement to the sides
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //If I hit right, move right
            vel.x = Speed;
            //If I hit right, mark that I'm not facing left
            FacingLeft = false;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            //If I hit left, move right
            vel.x = -Speed;
            //If I hit left, mark that I'm facing left
            FacingLeft = true;
        }
        else
        {
            //If I hit neither, come to a stop
            vel.x = 0;
        }

        //Here I actually feed the Rigidbody the movement I want
        RB.velocity = vel;

    }

    // take damage from colision with enemy 
    public void TakeDamage(int amt)
    {
        Health -= amt;
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
        //create a game over scene for this 
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("CAT"))
            Health--;

    }

}
