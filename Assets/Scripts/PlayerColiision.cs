using UnityEngine;

public class PlayerColiision : MonoBehaviour
{
    public Playermovement movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag=="Obstacle")
        {
            movement.enabled=false;
        }
    }
}
