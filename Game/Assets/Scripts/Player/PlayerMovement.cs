using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Manages the basic movement of the player
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    /// <summary>
    /// The value of the horizontal axis, which direction the player is going
    /// </summary>
    private float horizontal;
    /// <summary>
    /// The speed of the player
    /// </summary>
    private float speed = 8f;
    /// <summary>
    /// The jumping power of the player
    /// </summary>
    private float jumpingPower = 20f;
    /// <summary>
    /// Whether or not the player is facing right
    /// </summary>
    private bool isFacingRight = true;
    /// <summary>
    /// The animator that determines changes in animations
    /// </summary>
    public Animator animator;
    /// <summary>
    /// The ridgid body of the player
    /// </summary>
    [SerializeField] private Rigidbody2D rb;
    /// <summary>
    /// Object below the player to check for collisions with ground layer
    /// </summary>
    [SerializeField] private Transform groundCheck;
    /// <summary>
    /// Layer of the ground
    /// </summary>
    [SerializeField] private LayerMask groundLayer;

    /// <summary>
    /// Constantly updates the movement of the player, jump availibility, and check for flips
    /// </summary>
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        animator.SetFloat("Speed", Mathf.Abs(horizontal));
        animator.SetInteger("CurrentID", Inventory.currentID);

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

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
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 theScale = transform.localScale;
            theScale.x *= -1f;
            transform.localScale = theScale;

        }
    }
}
