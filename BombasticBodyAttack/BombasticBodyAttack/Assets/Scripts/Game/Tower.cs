using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    //FIELDS
    //Health
    public int health;

    //Cost
    public int cost;

    //METHODS
    protected virtual void Start() {
        Debug.Log("BASE TOWER");
    }

    //Lose Health
    public virtual bool LoseHealth(int amount){
        health -= amount;
        if (health <= 0){
            Die();
            return true;
        }
        return false;
    }

    //Destroy Tower
    protected virtual void Die(){
        Debug.Log("Tower Destroyed");
        Destroy(gameObject);
    }
}
