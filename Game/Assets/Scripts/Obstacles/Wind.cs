using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Creates a windzone that applies directional force to all objects in it
/// </summary>
public class Wind : MonoBehaviour
{
    /// <summary>
    /// The directional vector force being applied to the player as a 2D vector
    /// </summary>
    public Vector2 Force = Vector2.zero;

    /// <summary>
    /// List of objects in the windzone as a list of 2D collider
    /// </summary>
    private List<Collider2D> objects = new List<Collider2D>();

    /// <summary>
    /// For every object being tracked, get the ridgid body of the object and apply the directional force
    /// </summary>
    void FixedUpdate()
    {
        // Loop through every object in the windzone
        for (int i = 0; i < objects.Count; i++)
        {
            /// <summary>
            /// The ridgid body of the object colliding with the wind as a 2D ridgidbody
            /// </summary>
            Rigidbody2D body = objects[i].attachedRigidbody;
            body.AddForce(Force);
        }
    }

    /// <summary>
    /// Add collided object to list of items in windzone on collision
    /// </summary>
    void OnTriggerEnter2D(Collider2D other)
    {
        objects.Add(other);
    }

    /// <summary>
    /// Remove collided object to list of items in windzone off collision
    /// </summary>
    void OnTriggerExit2D(Collider2D other)
    {
        objects.Remove(other);
    }
}