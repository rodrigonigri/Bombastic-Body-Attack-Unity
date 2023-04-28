using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveTower : Tower
{
    //FIELDS
    //public
    public int damage;

    /* AudioSource source;

    void Awake() {
        source = GetComponent<AudioSource>();
    }*/


    protected override void Start() {
        Debug.Log("EXPLOSIVE TOWER");
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag == "Enemy"){
            Debug.Log("Enemy Hit");
            // slowly turn the tower into red
            StartCoroutine(DestroyEnemy());
            //other.GetComponent<Enemy>().LoseHealth(damage);
        }
    }

    //create IEnumerator to slowly turn the tower into red
    IEnumerator DestroyEnemy(){
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 0.5f);
        //turn the tower red
        GetComponent<SpriteRenderer>().color = Color.red;
        foreach (Collider2D collider in colliders)
        {
            if (collider.gameObject.tag == "Enemy")
            {   
                collider.GetComponent<SpriteRenderer>().color = Color.red;
                yield return new WaitForSeconds(0.5f);
                collider.GetComponent<Enemy>().LoseHealth(damage);
                //source.Play();
                Die();
                collider.GetComponent<SpriteRenderer>().color = Color.white;
                GetComponent<SpriteRenderer>().color = Color.white;

            }
        }
        

        

        // get the collider of the tower
       

        // destroy the enemy tht is colliding:
        

        
        
    }
}
