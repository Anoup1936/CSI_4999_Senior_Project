using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script represents a health collectible in a 2D game using Unity's engine.
public class HealthCollectible : MonoBehaviour
{
    // Public variable to set the amount of health restored upon interaction.
    public int collectibleHealth;

    // This function is called when a collider enters the trigger zone of this GameObject.
    void OnTriggerEnter2D(Collider2D other)
    {
        // Attempt to get the PlayerController component from the collider's GameObject.
        PlayerController controller = other.GetComponent<PlayerController>();

        // Check if the PlayerController component is found and the player's health is less than the maximum.
        if (controller != null && controller.health < controller.maxHealth)
        {
            // Call the ChangeHealth method on the PlayerController to increase the player's health.
            controller.ChangeHealth(collectibleHealth);
            Destroy(gameObject);
        }
    }
}
