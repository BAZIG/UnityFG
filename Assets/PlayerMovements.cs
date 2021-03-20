using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public float canJump = 0f;
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 1000f;
    public float upwaysForce = 1000f;


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
        if(Time.time > canJump && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0,upwaysForce* Time.deltaTime, 0);
            Debug.Log("Jump");
            canJump = Time.time + 0.3f;    
        }
    }
}