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
        if (!detectedTower){
            Move();
        }
        else{
            
        }
        
    }

    //Moving forward:
    void Move(){
        transform.Translate(-transform.right * moveSpeed * Time.deltaTime);
    }

    public void InflictDamge(){
        bool towerDied = detectedTower.LoseHealth(attackPower);

        if (towerDied){
            detectedTower = null;
            StopCoroutine(attackOrder);

        }
    }

    /*

    t_anterior = now() 


    Update
        if colisao:
            delta_ t = now() - t_anterior // da primeira vez vai ser rápido
            if delta_t >= 2: // cooldown = 2s
                t_anterior = now()
                ataque()
            else:
                return

    
    
    */

    IEnumerator Attack(){
        //play animation called "Virus_Attack"
            
        animator.Play("Virus_Attack");
        Debug.Log("Fez a animacao");
        yield return new WaitForSeconds(attackInterval);
        Debug.Log("Esperou o tempo");
        attackOrder = StartCoroutine(Attack());
        Debug.Log("Chamou a coroutine");

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

    private void OnTriggerEnter2D(Collider2D collision) {
        if(detectedTower){
            return;
        }

        if (collision.tag == "Tower"){ // fazer um booleano para usarmos em cima no if colisao e criar um trigger out para o booleano voltar a ser falso
            Debug.Log("Tower detected");
            detectedTower = collision.GetComponent<Tower>();
            attackOrder = StartCoroutine(Attack());
        }
    }
}
