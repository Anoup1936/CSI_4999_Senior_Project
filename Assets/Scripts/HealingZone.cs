using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script represents a healing zone in a 2D game using Unity's engine.
public class HealingZone : MonoBehaviour
{
    // Public variable to set the amount of health restored upon interaction.
    public int collectibleHealth;

    // This function is called when a collider stays within the trigger zone of this GameObject.
    void OnTriggerStay2D(Collider2D other)
    {
        // Attempt to get the PlayerController component from the collider's GameObject.
        PlayerController controller = other.GetComponent<PlayerController>();

        // Check if the PlayerController component is found and the player's health is less than the maximum.
        if (controller != null && controller.health < controller.maxHealth)
        {
            // Call the ChangeHealth method on the PlayerController to increase the player's health.
            controller.ChangeHealth(collectibleHealth);
        }
    }
}
