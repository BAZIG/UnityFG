using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 1000f;
    public float upwaysForce = 1000f;
    public float jumpHeight = 7f;
    public bool isGrounded;
    public float NumberJumps = 0f;
    public float MaxJumps = 2;

    void Update()
    {
        if (NumberJumps > MaxJumps - 1)
        {
            isGrounded = false;
        }

        if (isGrounded)
        {
            if (Input.GetButtonDown(KeyCode.Space))
            {
                rb.AddForce(0, sidewaysForce* Time.deltaTime, 0);
                NumberJumps += 1;
            }
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {

        if(Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sidewaysForce* Time.deltaTime, 0 , 0);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0, 0 , -sidewaysForce* Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0, 0 , sidewaysForce* Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sidewaysForce* Time.deltaTime, 0 , 0);
        }
        if(0.35 < transform.position.y && transform.position.y < 0.37 && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0,upwaysForce* Time.deltaTime, 0);
            Debug.Log("Jump");
            
        }
    }
    void OnCollisionEnter(Collision other)
    {
        isGrounded = true;
        NumberJumps = 0;
    }
    void OnCollisionExit(Collision other)
        {
            
    }
}