using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootItem : MonoBehaviour
{
    //Fields
    //graphics
    public Transform graphics;
    //damage
    public int damage;
    //speed
    public float flySpeed, rotateSpeed;

    //trigger mask layer
    public LayerMask enemyLayer;
    

    //Methods
    //Init
    public void Init(int dmg){
        damage = dmg;
    }
    //Trigger with enemy
    public void OnTriggerEnter2D(Collider2D collision){
        Debug.Log("entrei");
        if(collision.tag == "Enemy")
        {
            Debug.Log("Enemy Hit");
            Destroy(gameObject);
        }
        if(collision.tag == "Out")
        {
            Debug.Log("Out");
            Destroy(gameObject);
        }
        

    }

    //Handle Rotation
    void Update(){
        Rotate();
        FlyForward();
    }

    void Rotate(){
        graphics.Rotate(new Vector3(0,0,-rotateSpeed * Time.deltaTime));
    }

    void FlyForward(){
        transform.Translate(transform.right * flySpeed * Time.deltaTime);
    }

}
