using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    // List of towers that will instantiate
    public List<GameObject> towersPrefabs;

    // Transform of the spawning towers (Root Object)
    public Transform spawnTowerRoot;

    // list of towwers (UI)
    public List<Image> towersUI;

    // id of tower to spawn
    int spawnID = -1;

    // Spawnpoints Tilemap
    public Tilemap spawnTilemap;

    void Update(){
        if (CanSpawn()){
            DetectSpawnPoint();
        }
            
    }

    bool CanSpawn(){
        if (spawnID == -1){
            return false;
        }
        else{
            return true;
        }
    }

    void DetectSpawnPoint(){
        // Detect when mouse is clicked (first touch clicked)
        if (Input.GetMouseButtonDown(0)){
            // get the world space and position of the mouse
            var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // get the position of the cell in the tilemap
            var cellPosDefault = spawnTilemap.WorldToCell(mousePos);

            // get the center position of the cell
            var cellPosCentered = spawnTilemap.GetCellCenterWorld(cellPosDefault);

            //check if we can spawn in that cell (collider)
            if (spawnTilemap.GetColliderType(cellPosDefault) == Tile.ColliderType.Sprite){
                // spawn the tower

                // disable the collider
                SpawnTower(cellPosCentered);


            }
        }

            
    }


    void SpawnTower(Vector3 position){
        // spawn the tower
        GameObject tower = Instantiate(towersPrefabs[spawnID], spawnTowerRoot);
        tower.transform.position = position;

        DeselectTowers();

        // set the parent of the tower to the spawner
        tower.transform.SetParent(transform);
    }


    public void SelectTower (int id)
    {
        DeselectTowers();

        // select the spawn id
        spawnID = id;

        // highlight the tower in the UI
        towersUI[spawnID].color = Color.white;
    }
    

    public void DeselectTowers()
    {
        
        spawnID = -1;
        foreach (var t in towersUI)
        {
            t.color = new Color(0.5f, 0.5f, 0.5f, 1f);
        }
    }


}
