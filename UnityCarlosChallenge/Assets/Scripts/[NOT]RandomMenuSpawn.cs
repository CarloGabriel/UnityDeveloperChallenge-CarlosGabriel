using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMenuSpawn : MonoBehaviour

{
    
    public GameObject[] myObjects;

    void Start()
    {
        InvokeRepeating("RandomSpawn", 2.0f, 3f);
    }

    void RandomSpawn()
    {
            int randomIndex = Random.Range(0, myObjects.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(65, 2000), 1080, -99);

            Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity);

    }
}
   
