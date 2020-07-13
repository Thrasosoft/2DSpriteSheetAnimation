using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float jumpHieght = 10f;
    public Collider2D groundCollider;
    private Boolean isGrounded = false;
    private Rigidbody2D rigid;
    private Collider2D collider;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        collider = transform.GetChild(0).GetComponent<Collider2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float xAxis = Input.GetAxis("Horizontal");
        bool isMoving = xAxis != 0;
        anim.SetBool("isMoving", isMoving);
        if (xAxis > 0)
        {
            transform.localScale = new Vector3(3, 3);
        }
        if (xAxis < 0)
        {
            transform.localScale = new Vector3(-3, 3);
        }
        transform.Translate(transform.right * xAxis * Time.deltaTime * moveSpeed);

        //Determine if CRTL is being pressed
        bool attackButtonPressed = Input.GetKeyDown(KeyCode.LeftControl) || Input.GetKeyDown(KeyCode.RightControl);
        if (attackButtonPressed)
        {    //Trigger Attack() if CRTL is pressed
            Attack();
        }
    }

    private void FixedUpdate()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");
        if (collider.IsTouching(groundCollider))
        {
            isGrounded = true;
            anim.SetBool("isJumping", !isGrounded);
        }
        if (yAxis > 0 || Input.GetKeyDown("space"))
        {
            Jump(xAxis);
        }
    }

    void Jump(float xAxis)
    {
        if (isGrounded)
        {
            Vector2 force = new Vector2(xAxis, jumpHieght);
            rigid.AddForce(force);
            isGrounded = false;
            anim.SetBool("isJumping", !isGrounded);
        }
    }
    //New Attack Method
    private void Attack()
    {
        //Placeholder Attack logic.
        //A Trigger is a special type of Animation Parameter that automatically switches to false when the animation transistion is called.
        anim.SetTrigger("isAttacking");
    }

}
