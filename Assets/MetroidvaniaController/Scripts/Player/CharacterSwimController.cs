using UnityEngine;

public class CharacterSwimControler : MonoBehaviour
{
    private Rigidbody2D rb;

    Vector2 movement;

    public float moveSpeed;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = 10f;

    }



    private void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");


    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
        

    }
}