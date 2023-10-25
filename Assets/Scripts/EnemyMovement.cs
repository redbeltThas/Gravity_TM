using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public float yForce;
    public float xForce;
    public float xDirection;
    private Rigidbody2D enemyRigidBody;
    public int maximumXPosition;
    public int minimumXPosition;
    public float startingX;
    public float startingY;
    public int enemyCount;

    void Start()
    {
        enemyRigidBody = GetComponent<Rigidbody2D>();
        transform.position = new Vector3(startingX, startingY, transform.position.z);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Vector2 jumpForce = new Vector2(xForce * xDirection, yForce);
            enemyRigidBody.AddForce(jumpForce);
            if (transform.position.x > minimumXPosition && transform.position.x < maximumXPosition)
            {
                xDirection *= -1;
            }

        }

        if (collision.gameObject.tag == "Weapon")
        {
            Destroy(gameObject);

            GameObject.Find("Portal").GetComponent<Teleport>().enemyCount -= 1;

        }

        
        
    }

    private void FixedUpdate()
    {
        if (transform.position.x <= minimumXPosition)
        {
            xDirection = 1;

        }
        if (transform.position.x >= maximumXPosition)
        {
            xDirection = -1;

        }
        transform.position += Vector3.right * xForce * xDirection * Time.deltaTime;
    }

   
}
