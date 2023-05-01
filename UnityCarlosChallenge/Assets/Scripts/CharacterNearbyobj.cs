using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterNearbyobj : MonoBehaviour
{
    public GameObject[] Allterrain;
    public GameObject[] TerrainToClear;
    public List<GameObject> NearbyObj;
    float distance;
    float nearbyDistance = 5;
    [SerializeField] public GameObject toGoTerrain;

    private string PlayerIn = "Player1";
    private string PlayerNot = "Player2";
    private string PlayerAux = "";
    private GameObject PlayerToRename;
    private int count;

    void Update()
    {   
        if (Input.GetMouseButtonDown(0))
        {
            ClearToGo();
        }
        
        NearbyTerrain();
        
        if (gameObject.tag == "inTurn")
        {
           CreatToGoTerrain(); 
        }
        
        if (Input.GetMouseButtonDown(0))
        {
            count+=1;
            if(count == 3)
            {
                count = 0;
                changeTag();
                changeOrder();
            }
        }

    }

    void NearbyTerrain()
    {
        Allterrain = GameObject.FindGameObjectsWithTag("Terreno");
        NearbyObj.Clear();
        for (int i = 0; i < Allterrain.Length; i++)
        {
            distance = Vector3.Distance(this.transform.position, Allterrain[i].transform.position);

            if( distance < nearbyDistance)
            {
                GameObject enemy = GameObject.FindGameObjectWithTag("notInTurn");
                if(Allterrain[i].transform.position.x == enemy.transform.position.x && Allterrain[i].transform.position.z == enemy.transform.position.z)
                {
                    continue;
                }
                else
                {
                    NearbyObj.Add(Allterrain[i]);
                }
               
            }

        }
    }

    public void CreatToGoTerrain()
    {
        for (int i = 0; i < NearbyObj.Count; i++)
        {
            Instantiate(toGoTerrain, new Vector3(NearbyObj[i].transform.position.x, 0f, NearbyObj[i].transform.position.z), Quaternion.identity);
        }
    }
    
    public void ClearToGo()
    {
        TerrainToClear = GameObject.FindGameObjectsWithTag("TerrainGo");

        for (int i = 0; i < TerrainToClear.Length; i++)
        {
            Destroy(TerrainToClear[i]);
        }

    } 

    
    public void changeTag()
    {
        
        PlayerToRename = GameObject.Find (PlayerIn); 
        PlayerToRename.transform.gameObject.tag = "inTurn";

        PlayerToRename = GameObject.Find (PlayerNot); 
        PlayerToRename.transform.gameObject.tag = "notInTurn";
    }

    public void changeOrder()
    {
        PlayerAux = PlayerNot; 
        PlayerNot = PlayerIn;
        PlayerIn = PlayerAux;
    }
}
