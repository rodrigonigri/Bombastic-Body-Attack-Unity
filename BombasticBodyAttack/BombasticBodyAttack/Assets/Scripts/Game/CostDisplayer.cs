using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CostDisplayer : MonoBehaviour
{
    //FIELDS
    //tower ID
    public int towerID;

    //value
    public int towerCost;



    //METHODS
    //Init (Fetch the value from spwaner tower list)
    void Start(){
        towerCost = GameManager.instance.spawner.TowerCost(towerID);
        GetComponent<TextMeshProUGUI>().text = towerCost.ToString();

    }
}
