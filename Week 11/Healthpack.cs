using UnityEngine;

public class Healthpack : MonoBehaviour
{
    public PlayerHealth playerHealth;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerHealth.health += 10;
            Destroy(gameObject);
        }
    }
}
