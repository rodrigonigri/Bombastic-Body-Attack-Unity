using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingTower : MonoBehaviour
{
    //FIELDS
    //health
    public int health;

    //cost
    public int cost;

    //damage
    public int damage;

    //prefab (shooting item)
    public GameObject prefab_shootItem;

    //interval shoot
    public float interval;

    //METHODS
    //Init
    public void Start(){
        //Start shooting interval IEnum
        StartCoroutine(Interval());
    }
    //Interval for shooting
    IEnumerator Interval(){
        yield return new WaitForSeconds(interval);
        ShootItem();
        StartCoroutine(Interval());
    }
    //Shoot
    public void ShootItem(){
        //Instantiate the prefab
        GameObject shotItem = Instantiate(prefab_shootItem, transform);
        //Set its values
        //TODO: create shoot item script and set its values
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
        Debug.Log("Shooting Tower Destroyed");
        Destroy(gameObject);
    }
}
