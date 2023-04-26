using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health, attackPower;

    public float moveSpeed;

    void Update(){
        Move();
    }

    //Moving forward:
    void Move(){
        transform.Translate(-transform.right * moveSpeed * Time.deltaTime);
    }

    //Lose health if hit by a shoot item
    public void LoseHealth(){
        health --;
        StartCoroutine(BlinkRed());
        if (health <= 0){
            Destroy(gameObject);
        }

    }

    IEnumerator BlinkRed(){
        GetComponent<SpriteRenderer>().color = Color.red;
        yield return new WaitForSeconds(0.1f);
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
