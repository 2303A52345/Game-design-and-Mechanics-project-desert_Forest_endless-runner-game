
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    public float forwardSpeed = 8f;
    public float laneDistance = 3f;
    public float laneSpeed = 10f;
    public float jumpHeight = 2f;
    public float gravity = -20f;

    private CharacterController controller;
    private int currentLane = 1;
    private float verticalVelocity;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) ||
            Input.GetKeyDown(KeyCode.A))
            currentLane = Mathf.Max(0, currentLane - 1);

        if (Input.GetKeyDown(KeyCode.RightArrow) ||
            Input.GetKeyDown(KeyCode.D))
            currentLane = Mathf.Min(2, currentLane + 1);

        if (controller.isGrounded)
        {
            verticalVelocity = -1f;

            if (Input.GetKeyDown(KeyCode.Space))
                verticalVelocity = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        else
        {
            verticalVelocity += gravity * Time.deltaTime;
        }

        float targetX = (currentLane - 1) * laneDistance;

        float moveX = (targetX - transform.position.x)
                      * laneSpeed;

        Vector3 movement = new Vector3(
            moveX,
            verticalVelocity,
            forwardSpeed
        );

        controller.Move(movement * Time.deltaTime);
    }
}
