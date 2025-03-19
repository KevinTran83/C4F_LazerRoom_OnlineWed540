using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 6, lookSpeed = 150, jumpSpeed = 25;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // Camera Look
        Camera.main.transform.Rotate ( -Input.GetAxis("Mouse Y") * lookSpeed * Time.deltaTime,
                                       0,
                                       0
                                     );
        transform.Rotate ( 0,
                           Input.GetAxis("Mouse X") * lookSpeed * Time.deltaTime,
                           0
                         );

        // WASD movement
        Vector3 forward = transform.forward * Input.GetAxis("Vertical");
        Vector3 right   = transform.right   * Input.GetAxis("Horizontal");

        Vector3 moveDir = forward + right;
        rb.velocity = moveDir * moveSpeed + transform.up * rb.velocity.y;

        // Jumping
        bool onGround = Physics.Raycast(transform.position, -transform.up, 0.15f);
        if (onGround && Input.GetAxis("Jump") != 0) rb.AddForce(transform.up * jumpSpeed);
    }
}
