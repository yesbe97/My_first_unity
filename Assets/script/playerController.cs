using UnityEngine;

public class playerController : MonoBehaviour
{
    private CharacterController CC;
    private Vector3 moveDirection = Vector3.zero;

    private float speed = 6.0F;
    private float jumpSpeed = 8.0F;
    private float gravity = 20.0F;

    void Start()
    {
        CC = GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {
        if (CC.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
        }
        moveDirection.y -= gravity * Time.deltaTime;
        CC.Move(moveDirection * Time.deltaTime);
    }
}
