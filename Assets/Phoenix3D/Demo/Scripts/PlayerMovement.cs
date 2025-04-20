using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Movement speed
    public float rotationSpeed = 200f; // Rotation speed

    private Vector3 movement; // Movement vector

    void Update()
    {
        // Get input from WASD or arrow keys
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Create movement vector based on input
        movement = new Vector3(moveHorizontal, 0f, moveVertical);

        // Normalize movement to ensure consistent speed in diagonal directions
        if (movement.magnitude > 1)
        {
            movement.Normalize();
        }

        // Move the player
        transform.Translate(movement * speed * Time.deltaTime, Space.World);

        // Rotate the player based on horizontal input
        float rotation = moveHorizontal * rotationSpeed * Time.deltaTime;
        transform.Rotate(0f, rotation, 0f);
    }
}
