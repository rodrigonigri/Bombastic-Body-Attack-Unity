using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnergyTower : MonoBehaviour
{
    //FIELDS

    //Health
    public int health;

    //Income value
    public int incomeValue;

    //Interval for income
    public float interval;

    //Coin Image Object
    public GameObject obj_coin;

    //Cost
    public int cost;

    //METHODS
    //Init 
    public void Start(){
        StartCoroutine(Interval()); 
    }
    //Interval IEnumerator
    IEnumerator Interval(){
        yield return new WaitForSeconds(interval);
        IncreaseIncome();
        StartCoroutine(Interval());
    }

    //Trigger Income Increase
    public void IncreaseIncome(){
        GameManager.instance.currency.Gain(incomeValue);
        StartCoroutine(CoinIndiction());

    }
    // Show energy indication over the tower for short time (0.5 seconds)
    IEnumerator CoinIndiction(){
        obj_coin.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        obj_coin.SetActive(false);
    }

    //Lose Health
    public void LoseHealth(){
        health --;
        if (health <= 0){
            Die();
        }
    }
    
    //Destroy Tower
    public void Die(){
        Debug.Log("Tower Destroyed");
        Destroy(gameObject);
    }

    
}
