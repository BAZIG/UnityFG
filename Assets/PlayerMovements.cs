using UnityEngine;
using System.Collections;

public class PlayerMovements : MonoBehaviour
{
    public float canJump = 0f;
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 1000f;
    public float upwaysForce = 1000f;
	public bool canjump = false;
    bool grounded = false;
    public Transform groundCheck;
    void FixedUpdate()
    {
	    grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1<< LayerMask.NameToLayer("Ground"));
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
	     void OnCollisionEnter2D(Collision2D collision) 
		{
	    if ((grounded)&& Input.GetKey(KeyCode.Space)) {
            rb.AddForce(0,upwaysForce* Time.deltaTime, 0);
			Debug.Log("Jump");
        }
		}
    }
}