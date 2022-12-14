using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Manages the basic movement of left and right, 
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    /// <summary>
    /// The value of the horizontal axis of the direction the player is going as a float
    /// </summary>
    private float horizontal;
    /// <summary>
    /// The speed of the player as a float
    /// </summary>
    private float speed = 8f;
    /// <summary>
    /// The jumping power of the player as a float
    /// </summary>
    private float jumpingPower = 20f;
    /// <summary>
    /// Whether or not the player is facing right as a boolean
    /// </summary>
    private bool isFacingRight = true;
    /// <summary>
    /// The animator that determines changes in animations as an Animator 
    /// </summary>
    public Animator animator;
    /// <summary>
    /// The ridgid body of the player as a 2D ridgidbody
    /// </summary>
    [SerializeField] private Rigidbody2D rb;
    /// <summary>
    /// Object below the player to check for collisions with ground layer as a Transform
    /// </summary>
    [SerializeField] private Transform groundCheck;
    /// <summary>
    /// The ground layer as a Layermask 
    /// </summary>
    [SerializeField] private LayerMask groundLayer;

    /// <summary>
    /// Constantly awaits for key input and updates the position of the player, jump availibility, and check for flips
    /// </summary>
    void Update()
    {
        // Get the horizontal directional value of the player (-1, 0, 1)
        horizontal = Input.GetAxisRaw("Horizontal");

        // Gives the speed and current id of the player to the animator to determine animation
        animator.SetFloat("Speed", Mathf.Abs(horizontal));
        animator.SetInteger("CurrentID", Inventory.currentID);

        // Jump if the player is grounded and the jump button is pressed
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        // Slowly decrease the jump power as the jump button is held
        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        // Constantly checks if item needs to be flipped
        Flip();
    }

    /// <summary>
    /// Applies movement
    /// </summary>
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    /// <summary>
    /// Check if the player is grounded
    /// </summary>
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 1f, groundLayer);
    }

    /// <summary>
    /// Flip the sprite of the player to face the correct direction
    /// </summary>
    private void Flip()
    {
        // If the player is facing left and going right or facing right and going left, flip the item
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 theScale = transform.localScale;
            theScale.x *= -1f;
            transform.localScale = theScale;
        }
    }
}
