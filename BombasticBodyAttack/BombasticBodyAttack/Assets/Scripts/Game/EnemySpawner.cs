using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawner : MonoBehaviour
{
    public static EnemySpawner instance;
    void Awake(){ instance = this; }
    
    //Enemy prefabs
    public List<GameObject> prefabs;
    //Enemy spawn root points
    public List<Transform> spawnPoints;
    // Enemy spawn interval
    public float spawnInterval=2f;

    public int numero = 1;

    bool flag1 = false;
    bool flag2 = false;
    bool flag3 = false;


    public void StartSpawning()
    {
        // Call the spawn routine
        StartCoroutine(SpawnDelay());

    }

    public void Update(){
        if(flag1){
            if(GameManager.instance.health.GetHealthCount() > 0 && GameManager.instance.spawner.EnemiesAlive() == 0){
                Debug.Log("You win fase 1!");
                SceneManager.LoadScene("YouWinLevel1");

            }
        }
        if(flag2){
            if(GameManager.instance.health.GetHealthCount() > 0 && GameManager.instance.spawner.EnemiesAlive() == 0){
                Debug.Log("You win fase 2!");
                SceneManager.LoadScene("YouWinLevel2");
            }
        }
        if(flag3){
            if(GameManager.instance.health.GetHealthCount() > 0 && GameManager.instance.spawner.EnemiesAlive() == 0){
                Debug.Log("You win fase 3!");
                SceneManager.LoadScene("YouWinLevel3");
            }
        }
    }

    // spawnEnemy(X, Y) X --> 0-2 (0-bacteria, 1-parasita, 2-virus) Y --> 0-4

    IEnumerator SpawnDelay()
    {

        if(numero == 1){
            //////////////////////////////////////////// FASE 1 ////////////////////////////////////////////

            // Wait 10 seconds before spawning
            yield return new WaitForSeconds(15f);
            //UI "enemies are coming" message
            Debug.Log("Enemies are coming!");

            // Call spawn method
            SpawnEnemy(2, 2);
            // Wait spawn interval
            yield return new WaitForSeconds(15f);

            SpawnEnemy(2, 1);

            yield return new WaitForSeconds(15f);

            SpawnEnemy(2, 2);
            SpawnEnemy(2, 4);

            yield return new WaitForSeconds(15f);

            SpawnEnemy(2, 0);
            SpawnEnemy(2, 4);
            SpawnEnemy(2, 2);

            yield return new WaitForSeconds(15f);

            Debug.Log("A big wave of enemies is coming!");

            SpawnEnemy(2, 0);
            SpawnEnemy(2, 1);
            SpawnEnemy(2, 2);
            SpawnEnemy(2, 3);
            SpawnEnemy(2, 4);

            yield return new WaitForSeconds(5f);

            SpawnEnemy(2, 0);
            SpawnEnemy(2, 1);
            SpawnEnemy(2, 2);
            SpawnEnemy(2, 3);
            SpawnEnemy(2, 4);

            yield return new WaitForSeconds(5f);

            SpawnEnemy(2, 0);
            SpawnEnemy(2, 1);
            SpawnEnemy(2, 2);
            SpawnEnemy(2, 3);
            SpawnEnemy(2, 4);

            yield return new WaitForSeconds(15f);

            Debug.Log("A final wave of enemies is coming!");

            SpawnEnemy(2, 0);
            SpawnEnemy(2, 1);
            SpawnEnemy(2, 2);
            SpawnEnemy(2, 3);
            SpawnEnemy(2, 4);

            yield return new WaitForSeconds(3f);

            SpawnEnemy(2, 0);
            SpawnEnemy(2, 1);
            SpawnEnemy(2, 2);
            SpawnEnemy(2, 3);
            SpawnEnemy(2, 4);

            yield return new WaitForSeconds(3f);

            SpawnEnemy(2, 0);
            SpawnEnemy(2, 1);
            SpawnEnemy(2, 2);
            SpawnEnemy(2, 3);
            SpawnEnemy(2, 4);


            flag1 = true;
            
        }
        else if (numero == 2){
            //////////////////////////////////////////// FASE 2 ////////////////////////////////////////////

            // Wait 10 seconds before spawning
            yield return new WaitForSeconds(15f);
            //UI "enemies are coming" message
            Debug.Log("Enemies are coming!");

            // Call spawn method
            SpawnEnemy(1, 4);
            // Wait spawn interval
            yield return new WaitForSeconds(15f);

            SpawnEnemy(2, 1);

            yield return new WaitForSeconds(15f);

            SpawnEnemy(1, 0);
            SpawnEnemy(1, 4);

            yield return new WaitForSeconds(15f);

            SpawnEnemy(1, 0);
            SpawnEnemy(2, 4);
            SpawnEnemy(1, 2);
            SpawnEnemy(2, 3);

            yield return new WaitForSeconds(15f);

            Debug.Log("A big wave of enemies is coming!");

            SpawnEnemy(1, 0);
            SpawnEnemy(2, 1);
            SpawnEnemy(1, 2);
            SpawnEnemy(2, 3);
            SpawnEnemy(1, 4);

            yield return new WaitForSeconds(5f);

            SpawnEnemy(2, 0);
            SpawnEnemy(1, 1);
            SpawnEnemy(1, 2);
            SpawnEnemy(2, 3);
            SpawnEnemy(1, 4);

            yield return new WaitForSeconds(5f);

            SpawnEnemy(1, 0);
            SpawnEnemy(2, 1);
            SpawnEnemy(1, 2);
            SpawnEnemy(2, 3);
            SpawnEnemy(1, 4);

            yield return new WaitForSeconds(15f);

            Debug.Log("A final wave of enemies is coming!");
            
            SpawnEnemy(1, 0);
            SpawnEnemy(2, 1);
            SpawnEnemy(1, 2);
            SpawnEnemy(2, 3);
            SpawnEnemy(1, 4);

            yield return new WaitForSeconds(3f);

            SpawnEnemy(2, 0);
            SpawnEnemy(2, 1);
            SpawnEnemy(2, 2);
            SpawnEnemy(2, 3);
            SpawnEnemy(2, 4);

            yield return new WaitForSeconds(3f);

            SpawnEnemy(1, 0);
            SpawnEnemy(1, 1);
            SpawnEnemy(1, 2);
            SpawnEnemy(1, 3);
            SpawnEnemy(1, 4);

            yield return new WaitForSeconds(3f);

            SpawnEnemy(1, 0);
            SpawnEnemy(1, 1);	
            SpawnEnemy(1, 2);
            SpawnEnemy(1, 3);
            SpawnEnemy(1, 4);

            yield return new WaitForSeconds(3f);

            SpawnEnemy(2, 0);
            SpawnEnemy(2, 1);
            SpawnEnemy(2, 2);
            SpawnEnemy(2, 3);
            SpawnEnemy(2, 4);

            yield return new WaitForSeconds(3f);

            SpawnEnemy(1, 0);
            SpawnEnemy(1, 1);
            SpawnEnemy(1, 2);
            SpawnEnemy(1, 3);
            SpawnEnemy(1, 4);

            yield return new WaitForSeconds(3f);

            SpawnEnemy(1, 0);
            SpawnEnemy(1, 1);
            SpawnEnemy(1, 2);
            SpawnEnemy(1, 3);
            SpawnEnemy(1, 4);


            flag2 = true;
            

            
        }
        // 0-bacteria, 1-parasita, 2-virus
        else if (numero == 3){
            //////////////////////////////////////////// FASE 3 ////////////////////////////////////////////

            // Wait 10 seconds before spawning
            yield return new WaitForSeconds(20f);
            //UI "enemies are coming" message
            Debug.Log("Enemies are coming!");

            // Call spawn method
            SpawnEnemy(1, 1);
            // Wait spawn interval
            yield return new WaitForSeconds(15f);

            SpawnEnemy(0, 1);

            yield return new WaitForSeconds(15f);

            SpawnEnemy(2, 2);
            SpawnEnemy(0, 4);

            yield return new WaitForSeconds(15f);

            SpawnEnemy(0, 0);
            SpawnEnemy(1, 4);
            SpawnEnemy(2, 2);
            SpawnEnemy(0, 3);

            yield return new WaitForSeconds(15f);

            Debug.Log("A big wave of enemies is coming!");

            SpawnEnemy(0, 0);
            SpawnEnemy(1, 1);
            SpawnEnemy(0, 2);
            SpawnEnemy(2, 3);
            SpawnEnemy(1, 4);

            yield return new WaitForSeconds(5f);

            SpawnEnemy(1, 0);
            SpawnEnemy(0, 1);
            SpawnEnemy(2, 2);
            SpawnEnemy(2, 3);
            SpawnEnemy(1, 4);

            yield return new WaitForSeconds(5f);

            SpawnEnemy(0, 0);
            SpawnEnemy(1, 1);
            SpawnEnemy(0, 2);
            SpawnEnemy(1, 3);
            SpawnEnemy(0, 4);

            yield return new WaitForSeconds(15f);

            Debug.Log("A final wave of enemies is coming!");

            SpawnEnemy(0, 0);
            SpawnEnemy(2, 1);
            SpawnEnemy(0, 2);
            SpawnEnemy(2, 3);
            SpawnEnemy(1, 4);

            yield return new WaitForSeconds(5f);

            SpawnEnemy(0, 0);
            SpawnEnemy(1, 1);
            SpawnEnemy(0, 2);
            SpawnEnemy(2, 3);
            SpawnEnemy(1, 4);

            yield return new WaitForSeconds(5f);

            SpawnEnemy(0, 0);
            SpawnEnemy(0, 1);
            SpawnEnemy(1, 2);
            SpawnEnemy(2, 3);
            SpawnEnemy(1, 4);

            yield return new WaitForSeconds(5f);

            SpawnEnemy(2, 0);
            SpawnEnemy(0, 1);
            SpawnEnemy(1, 2);
            SpawnEnemy(1, 3);
            SpawnEnemy(2, 4);

            yield return new WaitForSeconds(5f);

            SpawnEnemy(2, 0);
            SpawnEnemy(0, 1);
            SpawnEnemy(1, 2);
            SpawnEnemy(2, 3);
            SpawnEnemy(2, 4);

            yield return new WaitForSeconds(5f);

            SpawnEnemy(0, 0);
            SpawnEnemy(0, 1);
            SpawnEnemy(0, 2);
            SpawnEnemy(0, 3);
            SpawnEnemy(0, 4);

            yield return new WaitForSeconds(5f);

            SpawnEnemy(0, 0);
            SpawnEnemy(0, 1);
            SpawnEnemy(0, 2);
            SpawnEnemy(0, 3);
            SpawnEnemy(0, 4);

            flag3 = true;
        }
    
        


        // Recall the same coroutine
        //StartCoroutine(SpawnDelay());
    }

    void SpawnEnemy(int randomPrefabID, int randomSpawnPointID)
    {
        
        // Randomize the enemy prefab

        // Spawn the enemy

        GameObject spawnedEnemy = Instantiate(prefabs[randomPrefabID], spawnPoints[randomSpawnPointID]);
    }

}
