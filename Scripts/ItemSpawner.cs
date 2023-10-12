using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject[] Items;
    public Transform itemSpawn;
    public float spawnInterval = 1.5f; 
    private float timeSinceLastSpawn = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= spawnInterval)
        {
            SpawnRandomPrefab();
            timeSinceLastSpawn = 0f;
        }
    }
    void SpawnRandomPrefab() 
    {
        float randomX = Random.Range(2f, 15f);
        float randomY = Random.Range(2f, 4f);
        int randomIndex = Random.Range(0, Items.Length);
        GameObject selectedPrefab = Items[randomIndex];
        if (selectedPrefab != null)
        {
            Instantiate(selectedPrefab, new Vector3(randomX, randomY, 0f), Quaternion.identity);
        }
    }

            // GameObject Items[]=(GameObject)Instantiate(Items,newVecctor3(randomX,randomY,0f),Quaternion.identity);
        
}
