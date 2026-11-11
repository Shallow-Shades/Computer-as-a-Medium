using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [Header("References")]
    public PlayerMana manaSystem;
    public GameObject objectToSpawn;

    [Header("Settings")]
    public float fireballCost = 20f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            CastFireball();
            SummonObject();
        }
    }

    void CastFireball()
    {
        if (manaSystem != null && manaSystem.TrySpendMana(fireballCost))
        {
            Debug.Log("Fireball cast!");
        }
    }
    void SummonObject()
    {
        if (objectToSpawn != null)
        {
            Instantiate(objectToSpawn, transform.position, Quaternion.identity);
        }
        else
        {
            Debug.LogWarning("No prefab assigned to ObjectSummoner!");
        }
    }
}
