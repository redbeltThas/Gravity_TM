using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityFlip : MonoBehaviour
{
    public Rigidbody2D avatarRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            avatarRigidbody.gravityScale *= -1f;
            Vector3 newDirection = transform.localScale;
         newDirection.y = newDirection.y * -1;
            Debug.Log(newDirection);
            gameObject.transform.localScale = newDirection;
        }
        
    }
}
