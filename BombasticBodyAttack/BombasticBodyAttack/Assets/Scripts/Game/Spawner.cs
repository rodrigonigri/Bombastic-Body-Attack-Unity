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

    //Tile position
    public Vector3Int tilePos;

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
                int towerCost = TowerCost(spawnID);
                if (GameManager.instance.currency.EnoughCurrency(towerCost)){
                    // use amunt of currency
                    GameManager.instance.currency.Use(towerCost);

                    // spawn the tower
                    SpawnTower(cellPosCentered, cellPosDefault);
                    AudioManager.instance.Play("PlacesTower");

                    // disable the collider
                    spawnTilemap.SetColliderType(cellPosDefault, Tile.ColliderType.None);
                }
                else{
                    Debug.Log("Not enough currency");
                }

            }
        }

    }

    public int TowerCost(int id){
        switch(id){
            case 2: return towersPrefabs[id].GetComponent<EnergyTower>().cost;
            case 3: return towersPrefabs[id].GetComponent<TankTower>().cost;
            case 0: return towersPrefabs[id].GetComponent<ShootingTower>().cost;
            case 1: return towersPrefabs[id].GetComponent<MultipleShootingTower>().cost;
            case 4: return towersPrefabs[id].GetComponent<ExplosiveTower>().cost;
            
            default: return -1;
        }
    }

    

    void SpawnTower(Vector3 position, Vector3Int cellPosition){
        // spawn the tower
        GameObject tower = Instantiate(towersPrefabs[spawnID], spawnTowerRoot);
        tower.transform.position = position;
        tower.GetComponent<Tower>().Init(cellPosition);     

        DeselectTowers();

        // set the parent of the tower to the spawner
        tower.transform.SetParent(transform);
    }

    public void RevertCellState(Vector3Int pos)
    {
        spawnTilemap.SetColliderType(pos, Tile.ColliderType.Sprite);
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

    // Create a function that returns the number of enemies alive in the scene:
    public int EnemiesAlive(){
        // Get all the enemies in the scene
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        // return the number of enemies
        return enemies.Length;
    }
    


}
