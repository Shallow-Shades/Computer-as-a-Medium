using UnityEngine;

public class ObjectSummoner : MonoBehaviour
{
    [Header("Settings")]
    public GameObject objectToSpawn;
    public KeyCode summonKey = KeyCode.F;
    public float currentMana;
    public float CurrentMana => currentMana;

    void Update()
    {
        if (Input.GetKeyDown(summonKey))
        {
            SummonObject();
        }
    }
    public bool TrySpendMana(float amount)
    {
        if (amount < 0f)
        {
            Debug.LogWarning($"TrySpendMana called with negative amount: {amount}");
            return false;
        }
        if (currentMana >= amount)
        {
            currentMana -= amount;
            return true;
        }
        return false;
    }
    void SummonObject()
    {
        if (objectToSpawn != null)
        {
            Instantiate(objectToSpawn, transform.position, Quaternion.identity);
        }
        else
        {
            Debug.LogWarning("No Mana");
        }
    }
}


