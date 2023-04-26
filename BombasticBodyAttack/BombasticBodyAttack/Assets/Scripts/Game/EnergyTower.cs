using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnergyTower : Tower
{
    //FIELDS
    //Income value
    public int incomeValue;

    //Interval for income
    public float interval;

    //Coin Image Object
    public GameObject obj_coin;


    //METHODS
    //Init 
    protected override void Start(){
        Debug.Log("ENERGY TOWER");
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


    
}
