using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A moving platform that cycles to every node in the array beginning at the starting point
/// </summary>
public class MovingPlatforms : MonoBehaviour
{
    /// <summary>
    /// Speed of the moving platform as a float
    /// </summary>
    public float speed;
    /// <summary>
    /// Starting point of the moving platform as an int
    /// </summary>
    public int startingPoint;
    /// <summary>
    /// List of points the moving platform will cycle through as an array of Transforms 
    /// </summary>
    public Transform[] points;
    /// <summary>
    /// The count of the cycle to reset the cycle when the end is reached as an int
    /// </summary>
    private int i;

    /// </summary>
    /// Transform the moving platform to its starting position
    /// </summary>
    void Start()
    {
        transform.position = points[startingPoint].position;
    }

    /// <summary>
    /// Transform the moving platform to the next platform, then reset the cycle when the end is reached
    /// </summary>
    void Update()
    {
        if (Vector2.Distance(transform.position, points[i].position) < 0.02f) {
            i++;
            // If the last node is reached, cycle back to the first node
            if (i == points.Length) {
                i = 0;
            }
        }

        // Move towards the next node
        transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
    }

    /// <summary>
    /// Sets the collided object's Transform as the parents transform, which helps the player stay on the platform
    /// </summary>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.SetParent(transform);      
    }

    /// <summary>
    /// Resets the collided object's Transform, allowing the player to move freely
    /// </summary>
    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.SetParent(null);
    }
}
