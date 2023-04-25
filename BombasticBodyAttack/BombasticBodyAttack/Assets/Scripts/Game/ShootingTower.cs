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
        //Set its position
        shotItem.transform.position = transform.position;
        //Sets its initial position 0.5f above the tower
        shotItem.transform.position += new Vector3(0.3f,0,0);
        //Set its scale
        shotItem.transform.localScale = new Vector3(0.3f,0.3f,1);
        //Set its values
        shotItem.GetComponent<ShootItem>().Init(damage);
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
