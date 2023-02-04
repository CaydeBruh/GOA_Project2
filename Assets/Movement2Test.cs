using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2Test : MonoBehaviour
{
    private float rotationSpeed = 0.5f;
    private Vector3 horizontalMovemenet;
    void Start()
    {
        
    }

    
    void Update()
    {
        horizontalMovemenet = new Vector3(0f, 0f, -Input.GetAxis("Horizontal"));

        transform.Rotate(horizontalMovemenet * rotationSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space))
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.up), 10f);


            if (hit)
            {
                Debug.Log("Hit " + hit.collider.name);
            }
        }
    }
}
