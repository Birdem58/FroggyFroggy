using System.Security.Cryptography;
using UnityEngine;


public class WaterDetection : MonoBehaviour
{
    public bool isInWater;
    public float tempGravityScale= 50;
    private Rigidbody2D rb;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
      
        if ( collision.gameObject.tag == "Water")
        {

            rb.gravityScale = 0;
            Debug.Log("sudayız");
            isInWater = true;
        }

        
    }

    void OnTriggerExit2D(Collider2D collision)
    {
       
        if (collision.gameObject.tag == "Water")
        {
            Debug.Log("suda değiliz");
            rb.gravityScale = tempGravityScale;
            isInWater = false;
        }
        

    }

}