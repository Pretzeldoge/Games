
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Movement no;
    public Rigidbody rb;
    void OnCollisionEnter (Collision Info)
    {
        if (Info.collider.tag == "Enemy") 
        { 
            no.enabled = false;
            rb.AddForce(0, 100000, 0);
        }
    }
}
