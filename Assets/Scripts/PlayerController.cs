using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
    public CharacterController controller;

    // Speed and Gravity
    private float speed = 7f;
    private float gravity = -9.8f;
    private Vector3 movement = Vector3.zero;
    public float verticalVelocity = 0f;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();

        // Apply Gravity
        verticalVelocity = gravity;
    }

    // Update is called once per frame
    void Update()
    {
        // Move the character
        movement = GetMovePosition();

        // Apply gravity (and Jump)
        movement.y = verticalVelocity;

        //Debug.Log(verticalVelocity.ToString());

        // Move the character with everything together
        controller.Move(movement * speed * Time.deltaTime);
    }

    // Move function
    Vector3 GetMovePosition()
    {
        Vector3 move;
        float forwardMovement, sideMovement;
        forwardMovement = Input.GetAxis("Vertical");
        sideMovement = Input.GetAxis("Horizontal");

        move = new Vector3(sideMovement, 0, forwardMovement);

        //Debug.Log("Target Rotation" + targetRotation);

        return move;
    }
}
