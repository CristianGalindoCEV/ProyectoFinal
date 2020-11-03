using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : PhysicsCollision
{
    private Rigidbody m_rb;
    [SerializeField] private float m_velocity = 10f;
    private Vector3 m_inputvector;
    public float jumpForce = 5;

    // Start is called before the first frame update
    void Start()
    {
        m_rb = GetComponent<Rigidbody>();

    }

    private void Update()
    {
        m_inputvector = new Vector3(Input.GetAxisRaw("Horizontal") * m_velocity, m_rb.velocity.y, Input.GetAxisRaw("Vertical") * m_velocity);
        transform.LookAt(transform.position + new Vector3(m_inputvector.x, 0, m_inputvector.z));
       
    }
   
    private void FixedUpdate()
    {
        m_rb.velocity = m_inputvector;
    }


    public void Jump()
    {
        if (!isGrounded)
            return;

        m_rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
