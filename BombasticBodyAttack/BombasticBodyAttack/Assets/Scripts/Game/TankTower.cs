using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankTower : MonoBehaviour
{
    //FIELDS

    //Health
    public int health;

    //Cost
    public int cost;

    //METHODS
    //Init
    public void Start(){
        
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
        Debug.Log("Tank Tower Destroyed");
        Destroy(gameObject);
    }
}
