using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Rigidbody2D rb;
    public Animator animator;

    [Space]

    public float moveSpeed = 7;
    protected float xFacing = 1;
    protected Vector2 moveInput;

    protected bool isWalking;

    void LateUpdate () {

        rb.velocity = moveInput.normalized * moveSpeed;

        if (moveInput.x > 0) {
            Turn (1);
        } else if (moveInput.x < 0) {
            Turn (-1);
        }

        isWalking = rb.velocity.magnitude > 0.25f;
        animator.SetBool ("isWalking", isWalking);

    }

    public void SetMoveInput (Vector2 moveInput) {
        this.moveInput = moveInput;
    }

    public void Turn (float xDir) {
        xDir = Mathf.Sign (xDir);
        transform.localScale = new Vector3 (xDir, 1, 1);
        xFacing = xDir;
    }

}