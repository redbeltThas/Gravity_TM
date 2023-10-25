using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public int enemyCount;
    public int gemCount;

    void Start()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        gemCount = GameObject.FindGameObjectsWithTag("Gem").Length;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
    if(collision.gameObject.tag == "Player" && enemyCount == 0){
        SceneManager.LoadScene(1);
     }

     if(collision.gameObject.tag == "Player" && gemCount == 0){
        SceneManager.LoadScene(0);
     }
   }

    // Update is called once per frame
    void Update()
    {
        
    }
}
