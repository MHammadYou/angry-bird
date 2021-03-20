using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float health = 4f;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.relativeVelocity.magnitude > health)
        {
            Destroy(gameObject);
        }
    }
}
