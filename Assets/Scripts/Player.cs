using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private Rigidbody2D myBody;
    private bool isJump = true;
    private float movementX, movementY;
    private float jumpForce;
    int jumpHeight = 15;

    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        float jumpForce = Mathf.Sqrt(jumpHeight * -2 * (Physics2D.gravity.y * myBody.gravityScale));



        if (Input.GetKeyDown("space") && isJump)
        {
            myBody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            isJump = false;
        }
        Movement();
    }

    void Movement()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementX, 0f,0f) * Time.deltaTime * speed;
    }
    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.CompareTag("Grounded"))
        {
            
            if(isJump == false)
            {
                isJump = true;
            }
        }
    }
}
