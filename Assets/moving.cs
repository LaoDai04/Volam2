using UnityEngine;
using UnityEngine.InputSystem;

public class SimpleMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    

    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        Vector3 moveDirection = new Vector3(moveInput.x, 0, moveInput.y).normalized;
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}
