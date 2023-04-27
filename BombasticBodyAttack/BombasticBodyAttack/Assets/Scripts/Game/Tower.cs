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
    private Vector3Int cellPosition;

    //METHODS
    protected virtual void Start() {
        Debug.Log("BASE TOWER");
    }

    public virtual void Init(Vector3Int cellPos)
    {
        cellPosition = cellPos;
    }

    //Lose Health
    public virtual bool LoseHealth(int amount){
        health -= amount;
        StartCoroutine(BlinkRed());
        if (health <= 0){
            // verify if object is not null
            if (gameObject != null){
                Die();
                return true;
            }
            
        }
        return false;
    }

    //Destroy Tower
    protected virtual void Die(){
        Debug.Log("Tower Destroyed");
        FindObjectOfType<Spawner>().RevertCellState(cellPosition);
        Destroy(gameObject);
    }


IEnumerator BlinkRed(){
        GetComponent<SpriteRenderer>().color = Color.red;
        yield return new WaitForSeconds(0.1f);
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}