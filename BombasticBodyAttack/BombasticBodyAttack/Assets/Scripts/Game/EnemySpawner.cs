using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public void StartSpawning()
    {
        // Call the spawn routine
        StartCoroutine(SpawnDelay());

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
            SpawnEnemy(1, 2);
            // Wait spawn interval
            yield return new WaitForSeconds(25f);

            SpawnEnemy(1, 1);

            yield return new WaitForSeconds(25f);

            SpawnEnemy(1, 2);
            SpawnEnemy(1, 4);

            yield return new WaitForSeconds(25f);

            SpawnEnemy(1, 0);
            SpawnEnemy(1, 4);
            SpawnEnemy(1, 2);

            yield return new WaitForSeconds(25f);

            Debug.Log("A big wave of enemies is coming!");

            SpawnEnemy(1, 0);
            SpawnEnemy(1, 1);
            SpawnEnemy(1, 2);
            SpawnEnemy(1, 3);
            SpawnEnemy(1, 4);

            yield return new WaitForSeconds(5f);

            SpawnEnemy(1, 0);
            SpawnEnemy(1, 1);
            SpawnEnemy(1, 2);
            SpawnEnemy(1, 3);
            SpawnEnemy(1, 4);

            yield return new WaitForSeconds(5f);

            SpawnEnemy(1, 0);
            SpawnEnemy(1, 1);
            SpawnEnemy(1, 2);
            SpawnEnemy(1, 3);
            SpawnEnemy(1, 4);

            yield return new WaitForSeconds(15f);

            Debug.Log("A final wave of enemies is coming!");
            
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

            SpawnEnemy(1, 0);
            SpawnEnemy(1, 1);
            SpawnEnemy(1, 2);
            SpawnEnemy(1, 3);
            SpawnEnemy(1, 4);

            /*

            if lifes > 0:
                
            */

        }
        else if (numero == 2){
            //////////////////////////////////////////// FASE 2 ////////////////////////////////////////////

            // Wait 10 seconds before spawning
            yield return new WaitForSeconds(2f);
            //UI "enemies are coming" message
            Debug.Log("Enemies are coming!");

            // Call spawn method
            SpawnEnemy(2, 2);
            // Wait spawn interval
            yield return new WaitForSeconds(25f);

            SpawnEnemy(2, 1);

            yield return new WaitForSeconds(25f);

            SpawnEnemy(2, 2);
            SpawnEnemy(2, 4);

            yield return new WaitForSeconds(25f);

            SpawnEnemy(2, 0);
            SpawnEnemy(2, 4);
            SpawnEnemy(2, 2);

            yield return new WaitForSeconds(25f);

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
        }

        else if (numero == 3){
            //////////////////////////////////////////// FASE 3 ////////////////////////////////////////////

            // Wait 10 seconds before spawning
            yield return new WaitForSeconds(20f);
            //UI "enemies are coming" message
            Debug.Log("Enemies are coming!");

            // Call spawn method
            SpawnEnemy(0, 2);
            // Wait spawn interval
            yield return new WaitForSeconds(25f);

            SpawnEnemy(0, 1);

            yield return new WaitForSeconds(25f);

            SpawnEnemy(0, 2);
            SpawnEnemy(0, 4);

            yield return new WaitForSeconds(25f);

            SpawnEnemy(0, 0);
            SpawnEnemy(0, 4);
            SpawnEnemy(0, 2);

            yield return new WaitForSeconds(25f);

            Debug.Log("A big wave of enemies is coming!");

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

            yield return new WaitForSeconds(5f);

            SpawnEnemy(0, 0);
            SpawnEnemy(0, 1);
            SpawnEnemy(0, 2);
            SpawnEnemy(0, 3);
            SpawnEnemy(0, 4);

            yield return new WaitForSeconds(15f);

            Debug.Log("A final wave of enemies is coming!");

            SpawnEnemy(0, 0);
            SpawnEnemy(0, 1);
            SpawnEnemy(0, 2);
            SpawnEnemy(0, 3);
            SpawnEnemy(0, 4);

            yield return new WaitForSeconds(3f);

            SpawnEnemy(0, 0);
            SpawnEnemy(0, 1);
            SpawnEnemy(0, 2);
            SpawnEnemy(0, 3);
            SpawnEnemy(0, 4);
            yield return new WaitForSeconds(3f);

            SpawnEnemy(0, 0);
            SpawnEnemy(0, 1);
            SpawnEnemy(0, 2);
            SpawnEnemy(0, 3);
            SpawnEnemy(0, 4);
        }
        else if (numero == 4){
            //////////////////////////////////////////// FASE 4 ////////////////////////////////////////////

            // Wait 10 seconds before spawning
            yield return new WaitForSeconds(15f);
            //UI "enemies are coming" message
            Debug.Log("Enemies are coming!");

            // Call spawn method
            SpawnEnemy(1, 2);
            // Wait spawn interval
            yield return new WaitForSeconds(25f);

            SpawnEnemy(1, 1);

            yield return new WaitForSeconds(25f);

            SpawnEnemy(1, 2);
            SpawnEnemy(1, 4);

            yield return new WaitForSeconds(25f);

            SpawnEnemy(1, 0);
            SpawnEnemy(1, 4);
            SpawnEnemy(1, 2);

            yield return new WaitForSeconds(25f);

            Debug.Log("A big wave of enemies is coming!");

            SpawnEnemy(1, 0);
            SpawnEnemy(1, 1);
            SpawnEnemy(1, 2);
            SpawnEnemy(1, 3);
            SpawnEnemy(1, 4);

            yield return new WaitForSeconds(5f);

            SpawnEnemy(1, 0);
            SpawnEnemy(1, 1);
            SpawnEnemy(1, 2);
            SpawnEnemy(1, 3);
            SpawnEnemy(1, 4);

            yield return new WaitForSeconds(5f);

            SpawnEnemy(1, 0);
            SpawnEnemy(1, 1);
            SpawnEnemy(1, 2);
            SpawnEnemy(1, 3);
            SpawnEnemy(1, 4);

            yield return new WaitForSeconds(15f);

            Debug.Log("A final wave of enemies is coming!");

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

            SpawnEnemy(1, 0);
            SpawnEnemy(1, 1);
            SpawnEnemy(1, 2);
            SpawnEnemy(1, 3);
            SpawnEnemy(1, 4);
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
