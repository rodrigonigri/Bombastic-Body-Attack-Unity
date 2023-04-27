using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health, attackPower;
    public float moveSpeed;

    public Animator animator;
    public float attackInterval;
    Coroutine attackOrder;
    Tower detectedTower;

    void Update(){
        if (detectedTower == null) 
        {
             Move();
        }
    }

    IEnumerator Attack() 
    {
        animator.Play("Virus_Attack",0,0);
        // wait attackinterval
        yield return new WaitForSeconds(attackInterval);
        // attack again  
        attackOrder = StartCoroutine(Attack());
    }

    //Moving forward:
    void Move(){
        animator.Play("Virus_Walking");
        transform.Translate(-transform.right * moveSpeed * Time.deltaTime);
    }

    public void InflictDamage()
    {
        bool towerDied = detectedTower.LoseHealth(attackPower);

        if (towerDied)
        {
            detectedTower = null;
            StopCoroutine(attackOrder);
        }

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

    private void OnTriggerEnter2D (Collider2D collision) 
    {
        if (detectedTower)
            return; 

        if (collision.tag == "Tower")
        {
            detectedTower = collision.GetComponent<Tower>();
            attackOrder = StartCoroutine(Attack());
        }
    }

    // ontriggerstay
}