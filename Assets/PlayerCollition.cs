using UnityEngine;

public class PlayerCollition : MonoBehaviour
{
    private Vector3 velocity;
    void OnCollisionEnter(Collision collisionInfo){
        if(collisionInfo.collider.name == "Obstacle")
        {
            transform.position = new Vector3(0, 1.01f, -41.07f);
            velocity.y = 0f;
            velocity.x = 0f;
            velocity.z = 0f;
        }
    }
    void Update(){
        if (transform.position.y < -1) // where -10 is the lowest the player can fall before reset
        {
        transform.position = new Vector3(0, 0.37f, -7.46f); // same as new Vector3(0, 0, 0);
        }
    }
}
