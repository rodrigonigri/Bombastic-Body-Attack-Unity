using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // List of towers that will instantiate

    public List<GameObject> towers;

    // id of tower to spawn

    int spawnID = -1;

    public void SelectTower (int id)
    {
        spawnID = id;
    }

    public void DeselectTower()
    {
        spawnID = -1;
    }

}
