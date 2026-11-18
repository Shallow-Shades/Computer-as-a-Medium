using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyDefeat_Text : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject Text;
    public GameObject Player;
    private IEnumerator DeathT()
    {
        Destroy(Player);
        Text.SetActive(true);
        yield return new WaitForSeconds(1f);
        Destroy(Player);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    void Update()
    {
        GameEnd();
    }

    void GameEnd()
    {
        if (Enemy = null)
        StartCoroutine(DeathT());
    }

}
       