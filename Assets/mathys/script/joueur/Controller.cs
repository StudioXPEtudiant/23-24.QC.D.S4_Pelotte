using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public Rigidbody2D rb2d; 
    public float Speed = 5;
    public float jumpSpeed = 5;
    bool isGrounded = true;


    // Start is called before the first frame update
    void Start()
    {
        rb2d =  GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        float h = Input.GetAxis("Horizontal") * Speed;

        rb2d.velocity = new Vector2(h, rb2d.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isGrounded = false;
            StartCoroutine("JumpCoolDown");
            rb2d.AddForce(transform.up * jumpSpeed, ForceMode2D.Impulse);
        }
        

        
    }

    IEnumerator JumpCoolDown()
 {
    yield return new WaitForSeconds(1);
    isGrounded = true;
 }
}
