using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HLevelManager : MonoBehaviour
{
    public GameObject Knight;
    public GameObject Wizard;
    private string Player;

    GameObject[] RandomSpawnPoint = GameObject.FindGameObjectsWithTag("Terreno");
    

    void Player1()
    {
        Player = "Player1";
    }

    void Player2()
    {
        Player = "Player1";
    }

     void SpawnPlayerKnight()
    {
        int SpawnPoint = Random.Range(15,31);
        Instantiate(Knight, new Vector3(RandomSpawnPoint[SpawnPoint].transform.position.x, -1f, RandomSpawnPoint[SpawnPoint].transform.position.z), Quaternion.identity);
        GameObject PlayerToRename = GameObject.Find ("Knight"); 
        PlayerToRename.name = Player;
    }

    void SpawnPlayerWizard()
    {
        int SpawnPoint = Random.Range(15,31);
        Instantiate(Wizard, new Vector3(RandomSpawnPoint[SpawnPoint].transform.position.x, -1f, RandomSpawnPoint[SpawnPoint].transform.position.z), Quaternion.identity);
        GameObject PlayerToRename = GameObject.Find ("Knight"); 
        PlayerToRename.name = Player;
    }
}
