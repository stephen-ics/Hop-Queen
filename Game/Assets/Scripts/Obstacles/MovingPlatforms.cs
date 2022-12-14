using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A moving platform that cycles to every point in the list beginning at the starting point
/// </summary>
public class MovingPlatforms : MonoBehaviour
{
    /// <summary>
    /// Speed of the moving platform
    /// </summary>
    public float speed;
    /// <summary>
    /// Starting point of the moving platform
    /// </summary>
    public int startingPoint;
    /// <summary>
    /// List of points the moving platform will cycle through 
    /// </summary>
    public Transform[] points;
    /// <summary>
    /// The count of the cycle to reset the cycle when the end is reached
    /// </summary>
    private int i;

    /// </summary>
    // Transform the moving platform to its starting position
    /// </summary>
    void Start()
    {
        transform.position = points[startingPoint].position;
    }

    /// <summary>
    // Transform the moving platform to the next platform, then reset the cycle when the end is reached
    /// </summary>
    void Update()
    {
        if (Vector2.Distance(transform.position, points[i].position) < 0.02f) {
            i++;
            if (i == points.Length) {
                i = 0;
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
    }

    /// <summary>
    /// Sets transform as the collided object's new parent on collision to allow the player to stay on platform
    /// </summary>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.SetParent(transform);      
    }

    /// <summary>
    /// Resets parent of the collided object off collision
    /// </summary>
    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.SetParent(null);
    }
}
