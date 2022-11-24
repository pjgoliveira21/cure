using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    public Rigidbody2D rb2d;
    public Animator animator;
    public Vector2 movementDelta;

    public int lastPos;

    void Update()
    {
        movementDelta.x = Input.GetAxisRaw("Horizontal");
        movementDelta.y = Input.GetAxisRaw("Vertical");
        
        animator.SetFloat("Speed", movementDelta.sqrMagnitude);
        animator.SetFloat("Vertical", movementDelta.y);
        animator.SetFloat("Horizontal", movementDelta.x);

        if(movementDelta.x==0 && movementDelta.y==1) lastPos=1; //Last position up
        if(movementDelta.x==-1 && movementDelta.y==0) lastPos=2; //Last position left
        if(movementDelta.x==0 && movementDelta.y==-1) lastPos=3; //Last position down
        if(movementDelta.x==1 && movementDelta.y==0) lastPos=4;  //Last position right
        animator.SetFloat("LastPos", lastPos);
    }

    void FixedUpdate() {
        rb2d.MovePosition(rb2d.position + movementDelta.normalized * speed * Time.fixedDeltaTime);
    }
}
