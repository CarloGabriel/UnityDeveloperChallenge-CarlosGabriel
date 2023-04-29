using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMenuSpawn : MonoBehaviour

{
    

     public GameObject[] myObjects;

    void Update()
    {
            int randomIndex = Random.Range(0, myObjects.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-950, 950), 671, -99);

            Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity);

    }
}
   
