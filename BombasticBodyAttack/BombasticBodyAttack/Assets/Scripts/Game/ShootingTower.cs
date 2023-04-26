using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingTower : Tower
{
    //FIELDS
    //damage
    public int damage;

    //prefab (shooting item)
    public GameObject prefab_shootItem;

    //interval shoot
    public float interval;

    //METHODS
    //Init
    protected override void Start(){
        //Start shooting interval IEnum
        Debug.Log("SHOOTING TOWER");
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
}
