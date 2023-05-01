using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SLevelManager : MonoBehaviour
{
    public GameObject[] Allterrain;
    public GameObject Knight;
    public GameObject Wizard;
    public GameObject[] itens;
    GameObject PlayerToRename;
    private string Player;
    private int SpawnPoint = 1;
    private int randAux =1;
    GameObject[] RandomSpawnPoint;
    
    void Start()
    {
        RandomSpawnPoint = GameObject.FindGameObjectsWithTag("Terreno");
    }

    public void Player1()
    {
        Player = "Player1";
    }

    public void Player2()
    {
        Player = "Player2";
    }

    public void SpawnPlayerKnight()
    {
        
            int SpawnPoint = getRandom();

        Instantiate(Knight, new Vector3(RandomSpawnPoint[SpawnPoint].transform.position.x, 0.3f, RandomSpawnPoint[SpawnPoint].transform.position.z), Quaternion.identity);
        PlayerToRename = GameObject.Find ("KnightCharacter(Clone)"); 
        PlayerToRename.name = Player;

    }

    public void SpawnPlayerWizard()
    {
            int SpawnPoint = getRandom();
        
        Instantiate(Wizard, new Vector3(RandomSpawnPoint[SpawnPoint].transform.position.x, 0.3f, RandomSpawnPoint[SpawnPoint].transform.position.z), Quaternion.identity);
        PlayerToRename = GameObject.Find ("WizardCharacter(Clone)"); 
        PlayerToRename.name = Player;

    }

    public void SpawnItens()
    {
        Allterrain = GameObject.FindGameObjectsWithTag("Terreno");
        GameObject player1 = GameObject.FindGameObjectWithTag("inTurn");
        GameObject player2 = GameObject.FindGameObjectWithTag("notInTurn");

        for (int i = 0; i < Allterrain.Length; i++)
        {
            int indexRandom =Random.Range(0,2);
            if(Allterrain[i].transform.position.x == player1.transform.position.x && Allterrain[i].transform.position.z == player1.transform.position.z)
            {
                continue;
            }
            else if(Allterrain[i].transform.position.x == player2.transform.position.x && Allterrain[i].transform.position.z == player2.transform.position.z)
            {
                continue;
            }
            else
            {
                Instantiate(itens[indexRandom], new Vector3(Allterrain[i].transform.position.x, 0f, Allterrain[i].transform.position.z), Quaternion.identity);
            }
               
        }
    }


    public void ButtonDisable([SerializeField]string buttonReference)
    {
        Button ButtontoDisable = GameObject.Find(buttonReference).GetComponent<Button>();
        ButtontoDisable.interactable = false;
    }

    public void ButtonRemove([SerializeField] string buttonReference)
    {
        Button ButtontoRemove = GameObject.Find(buttonReference).GetComponent<Button>();
        ButtontoRemove.gameObject.SetActive(false);
    }

    public void CloseLevelEditor(GameObject LevelMenu)
    {
        initalTag();
        LevelMenu.SetActive(false);
        
        
    }

        public void OpenUI(GameObject GameplayUI)
    {
        GameplayUI.SetActive(true);
    }

    public int getRandom()
    {
        
        if (randAux == 1){
            randAux++;
            return(Random.Range(15,31));
            
        }else{
           return(Random.Range(194,223)); 
        }
        
    }

    public void initalTag()
    {
        PlayerToRename = GameObject.Find ("Player1");
        PlayerToRename.transform.gameObject.tag = "inTurn";
        PlayerToRename = GameObject.Find ("Player2");
        PlayerToRename.transform.gameObject.tag = "notInTurn";
    }

}
