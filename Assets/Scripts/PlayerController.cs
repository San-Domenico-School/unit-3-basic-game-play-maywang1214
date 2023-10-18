using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject projectile;
    private float speed;
    private float centerToEdge;
    private float moveX; // Horizontal movement
    private float moveY; // Vertical movement
    private float maxSpeed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 13.0f;
        centerToEdge = 24.5f;
        //to be implemented
    }

    // to call the PlayerMovement method each frame
    void Update()
    {
        PlayerMovement();
    }

    // This method is responsible for moving the player left and right.
    // It prevents the player from moving beyond the centerToEdge mark.
    private void PlayerMovement()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed * moveX);
        if (transform.position.x > centerToEdge)
        {
            transform.position = new Vector3(centerToEdge, transform.position.y, transform.position.z);
        }
    }

    // OnMove is called when the Move action of the PlayerInputAction detects an input from the player.
    // It sets the "move" field to either 1 or -1 based on the x-value of the input's Vector2.
    private void OnMove(InputValue input)
    {
        Vector2 inputVector = input.Get<Vector2>();
        moveX = inputVector.x;

    }

    private void OnFire()
    {
        Instantiate(projectile, transform.position + Vector3.up, projectile.transform.rotation);
    }
}
