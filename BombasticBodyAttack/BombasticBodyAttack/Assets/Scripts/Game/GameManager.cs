using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    void Awake(){ instance = this; }

    public Spawner spawner;
    public HealthSystem health;
    public CurrencySystem currency;

    void Start()
    {
        GetComponent<HealthSystem>().Init();
        GetComponent<CurrencySystem>().Init();

        StartCoroutine(WaveStartDelay());
    }

    IEnumerator WaveStartDelay(){
        //wait for x seconds
        yield return new WaitForSeconds(2f);
        //start enemies spawning
        EnemySpawner.instance.StartSpawning();

    }
}
