using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed, jump;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity.Set(speed, 0, 0);
    }

    private void FixedUpdate()
    {
        //if (Input.GetKey(KeyCode.A))
        //{
        //    rb.linearVelocity.Set(-speed, rb.linearVelocity.y, rb.linearVelocity.z);
        //}

        //else if (Input.GetKey(KeyCode.D))
        //{
        //    rb.linearVelocity.Set(speed, rb.linearVelocity.y, rb.linearVelocity.z);
        //}

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    rb.AddForce(new Vector3 (0, jump, 0));
        //}
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Ground")
        {
            speed = -speed;
        }
        if (collision.gameObject.tag == "Ball")
        {
            rb.AddForce(0, jump, 0);
        }
    }
}
