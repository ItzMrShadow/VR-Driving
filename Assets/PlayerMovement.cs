using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // The movement speed of the player.
    private float mouseX, mouseY; // The mouse input values.
    public float sensitivity = 100f; // The sensitivity of the mouse.

    private CharacterController controller; // The character controller component.

    void Start()
    {
        controller = GetComponent<CharacterController>(); // Get the character controller component of the player object.
        Cursor.lockState = CursorLockMode.Locked; // Lock the cursor to the center of the screen.
    }

    void Update()
    {
        // Get the mouse input values.
        mouseX += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        mouseY -= Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        mouseY = Mathf.Clamp(mouseY, -90f, 90f); // Limit the vertical mouse movement.

        // Rotate the camera based on the mouse input values.
        transform.eulerAngles = new Vector3(mouseY, mouseX, 0f);

        // Get the horizontal and vertical input values.
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Create a movement vector based on the input values.
        Vector3 movement = transform.forward * vertical + transform.right * horizontal;

        // Move the player based on the movement vector, speed, and time.
        controller.Move(movement * speed * Time.deltaTime);
    }
}
