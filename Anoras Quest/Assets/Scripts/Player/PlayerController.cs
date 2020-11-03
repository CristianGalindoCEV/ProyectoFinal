using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : PhysicsCollision
{
    private Rigidbody rb;
    public float speed;
    private float axisX;
    private Vector2 m_velocity;
    public float jumpForce = 5;
    // public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    protected override void FixedUpdate()
    {
        base.FixedUpdate();

        m_velocity = rb.velocity;
        m_velocity.x = speed * axisX;
        if (touchWall)
            m_velocity.x = 0;

        rb.velocity = m_velocity;

    }

    public void SetAxis(float x)
    {
        axisX = x;
    }

    public void Jump()
    {
        if (!isGrounded)
            return;

        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
