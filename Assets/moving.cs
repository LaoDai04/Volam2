using UnityEngine;
using UnityEngine.InputSystem;

public class SimpleMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    

    void Update()
    {
        // Get input from the user
        Mouse mouse = Mouse.current;
        float horizontalInput = mouse.in;
        float verticalInput = mouse.delta.y.ReadValue();

        // Create a movement vector based on input
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput) * moveSpeed * Time.deltaTime;
        // Move the object
        transform.Translate(movement);
    }
}
