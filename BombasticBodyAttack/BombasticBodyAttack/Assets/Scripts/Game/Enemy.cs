using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health, attackPower;
    public float moveSpeed;

    public Animator animator;
    public float attackInterval;

    // current time now
    
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
        // debug:
        Debug.Log("Attack");
        animator.Play("Attack",0,0);
        // wait attackinterval
        yield return new WaitForSeconds(attackInterval);
        // attack again  
        attackOrder = StartCoroutine(Attack());
    }

    //Moving forward:
    void Move(){
        animator.Play("Walking");
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
    public void LoseHealth(int amount){
        health -= amount;
        StartCoroutine(BlinkRed());
        if (health <= 0){
            AudioManager.instance.Play("EnemyDies");
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
            Debug.Log("contato");
            detectedTower = collision.GetComponent<Tower>();
            attackOrder = StartCoroutine(Attack());
        }
        if (collision.tag == "EnemyOut")
        {
            Debug.Log("Out");
            // Destroy enemy
            Destroy(gameObject);

            // Call function loose health from file HealthSystem.cs
            FindObjectOfType<HealthSystem>().LoseHealth();
            

            
        }
    }

    // ontriggerstay
}