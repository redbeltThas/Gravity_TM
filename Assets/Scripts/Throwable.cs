using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Throwable : MonoBehaviour
{
    public GameObject objectThrown;
    public Vector3 offset;
    public int throwableCounter = 0;
    public Text collectableCounter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        offset = transform.localScale.x * new Vector3(1, 0, -1);
        Vector3 throwablePosition = transform.position + offset;

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(objectThrown, throwablePosition, transform.rotation);
            throwableCounter -= 1;
            collectableCounter.text = throwableCounter.ToString();
        }

      
        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Collectable")
        {
            throwableCounter += 1;
            Destroy(collision.gameObject);
            collectableCounter.text = throwableCounter.ToString();
   
            

        }

    }
}
