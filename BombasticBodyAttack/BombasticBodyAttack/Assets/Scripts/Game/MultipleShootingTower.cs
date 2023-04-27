using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleShootingTower : Tower
{
    public int damage;
    public GameObject prefab_shootItem;
    public float interval;

    protected override void Start()
    {
        Debug.Log("MULTIPLE SHOOTING TOWER");
        StartCoroutine(Interval());
    }

    IEnumerator Interval()
    {
        yield return new WaitForSeconds(interval);
        ShootItem();
        StartCoroutine(Interval());
    }

    public void ShootItem()
    {
        GameObject shotItem1 = Instantiate(prefab_shootItem, transform);
        GameObject shotItem2 = Instantiate(prefab_shootItem, transform);
        GameObject shotItem3 = Instantiate(prefab_shootItem, transform);
        GameObject shotItem4 = Instantiate(prefab_shootItem, transform);


        //spin 60 degrees shot item 2 and -10 degrees shot item 3
        shotItem2.transform.Rotate(0, 0, 10);
        shotItem3.transform.Rotate(0, 0, -10);
        shotItem4.transform.Rotate(0, 0, -90);


        


        shotItem1.transform.position = transform.position;
        shotItem1.transform.position += new Vector3(0.3f, 0, 0);
        shotItem1.transform.localScale = new Vector3(0.3f, 0.3f, 1);
        shotItem1.GetComponent<ShootItem>().Init(damage);

        shotItem2.transform.position = transform.position;
        shotItem2.transform.position += new Vector3(0.3f, 0, 0f);
        shotItem2.transform.localScale = new Vector3(0.3f, 0.3f, 1);
        shotItem2.GetComponent<ShootItem>().Init(damage);

        shotItem3.transform.position = transform.position;
        shotItem3.transform.position += new Vector3(0.3f, 0, 0);
        shotItem3.transform.localScale = new Vector3(0.3f, 0.3f, 1);
        shotItem3.GetComponent<ShootItem>().Init(damage);

        //shot item 4 to the left

        shotItem4.transform.position = transform.position;
        shotItem4.transform.position += new Vector3(-0.5f, 0, 0);
        shotItem4.transform.localScale = new Vector3(0.3f, 0.3f, 1);
        shotItem4.GetComponent<ShootItem>().Init(damage);


    }
}
