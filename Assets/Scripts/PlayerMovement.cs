using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    CapsuleCollider selfCollider;
    Rigidbody rb;

    public float JumpSpeed = 12;

    int laneNumber = 1,
    lanesCount = 2;

    public float FirstLanePos,
    LaneDistance,
    SideSpeed;

    bool wannaJump = false;

    void Start()
    {
        selfCollider = GetComponent<CapsuleCollider>();
        rb = GetComponent<Rigidbody>();

        SwipeController.SwipeEvent += CheckInput;
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(0, Physics.gravity.y * 4, 0), ForceMode.Acceleration);

        if (wannaJump && isGrounded())
        {
            rb.AddForce(new Vector3(0, JumpSpeed, 0), ForceMode.Impulse);
            wannaJump = false;
        }
    }

    void Update()
    {
        Vector3 newPos = transform.position;
        newPos.z = Mathf.Lerp(newPos.z, FirstLanePos + (laneNumber * LaneDistance), Time.deltaTime * SideSpeed);
        transform.position = newPos;
    }

    void CheckInput(SwipeController.SwipeType type)
    {
        if (isGrounded())
        {
            if (type == SwipeController.SwipeType.UP)
                wannaJump = true;
        }

        int sign = 0;

        if (type == SwipeController.SwipeType.LEFT)
        sign = -1;
        else if (type == SwipeController.SwipeType.RIGHT)
        sign = 1;
        else
        return;

        laneNumber += sign;
        laneNumber = Mathf.Clamp(laneNumber, 0, lanesCount);
    }

    bool isGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, 0.05f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Trap"))
        return;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}