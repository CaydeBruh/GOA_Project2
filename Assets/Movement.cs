using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10f;
    public float jumpForce = 5f;
    //Components
    private Rigidbody2D rb2d;
    private SpriteRenderer sprite;
    private BoxCollider2D bCol2d;
    //Private attributes
    private bool jump = false;
    private Rigidbody2D Player;
    public ProjectileBehavior ProjectilePrefab;
    public Transform LaunchOffSet;

    void Start()
    {
        
        Player.AddForce(new Vector2(speed, 0), ForceMode2D.Impulse);
        rb2d = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        bCol2d = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        float HorizontalValue = Input.GetAxis("Horizontal");
        float VerticalValue = Input.GetAxis("Vertical");

        if (HorizontalValue < 0)
        {

            transform.Translate(-0.005f, 0f, 0f);

        }

        if (HorizontalValue > 0)
        {
            transform.Translate(0.005f, 0f, 0f);

        }

        if (VerticalValue < 0)
        {
            transform.Translate(0f, -0.005f, 0f);
        }

        if (VerticalValue > 0)
        {
            transform.Translate(0f, 0.025f, 0f);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
          


         }

        if(Input.GetKey(KeyCode.F))
        {
            Instantiate(ProjectilePrefab, LaunchOffSet.position, transform.rotation);
        }
    }


    void FixedUpdate()
    {
        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxis("Horizontal");

        if (moveHorizontal < 0)
        {
            sprite.flipX = false;
        }
        else if (moveHorizontal > 0)
        {
            sprite.flipX = true;
        }
    }
    }




