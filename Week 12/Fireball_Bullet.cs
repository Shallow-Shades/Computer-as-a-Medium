using UnityEngine;

public class Fireball_Bullet : MonoBehaviour
{
    public float speed = 10f;
    public float destroyTime = 3f;

    public Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.linearVelocity = transform.up * speed;
        Destroy(gameObject, destroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
