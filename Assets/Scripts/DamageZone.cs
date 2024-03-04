using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script represents a damage zone in a 2D game using Unity's engine.
public class DamageZone : MonoBehaviour
{
    // Public variable to set the amount of damage inflicted upon interaction.
    public int damage;

    // This function is called when a collider stays within the trigger zone of this GameObject.
    void OnTriggerStay2D(Collider2D other)
    {
        // Attempt to get the PlayerController component from the collider's GameObject.
        PlayerController controller = other.GetComponent<PlayerController>();

        // Check if the PlayerController component is found.
        if (controller != null)
        {
            // Call the ChangeHealth method on the PlayerController to decrease the player's health.
            controller.ChangeHealth(damage);
        }
    }
}
