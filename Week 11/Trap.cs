using UnityEngine;

public class Trap : MonoBehaviour
{
    public PlayerHealth playerHealth;
    void Start()
    {

    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            playerHealth.health -= 10;
        }
    }
}
