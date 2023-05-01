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

    public int[] danoS;
    public int[] danoF;

    public int playerIn = 0;
    public int playerNotIn = 0;

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
                    First();
                    Second();
                    Battle();
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
        for (int j = 0; j < NearbyObj.Count; j++)
        {
            Instantiate(toGoTerrain, new Vector3(NearbyObj[j].transform.position.x, -0.6f, NearbyObj[j].transform.position.z), Quaternion.identity);
        }
    }
    
    public void ClearToGo()
    {
        TerrainToClear = GameObject.FindGameObjectsWithTag("TerrainGo");

        for (int k = 0; k < TerrainToClear.Length; k++)
        {
            Destroy(TerrainToClear[k]);
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

    public void First()
     {
        
        
        for (int i = 0; i < ((GameObject.FindGameObjectWithTag("inTurn")).GetComponent<Status>().DCS); i++)
        {
            if(i<3)
            {
                danoF[i] = Random.Range(0,6);
            }
            if(i>=3)
            {
                danoF[i] =Random.Range(0,12);
            }
        System.Array.Reverse(danoF);
        }
    }

    public void Second()
    {

        for (int i = 0; i < ((GameObject.FindGameObjectWithTag("notInTurn")).GetComponent<Status>().DCS); i++)
        {
            if(i<3)
            {
                danoS[i] = Random.Range(0,6);
            }
            if(i>=3)
            {
                danoS[i] = Random.Range(0,12);
            }
        System.Array.Reverse(danoS);
        }
    }

    public void Battle()
    {
        playerIn = 0;
        playerNotIn = 0;

        for(int l = 0; l < 3; l++)
        {
            if(danoF[l]<danoS[l])
            {
                playerIn +=1;
            }else{
                playerNotIn +=1;
            }
        }

        if(playerIn>playerNotIn)
        {
            (GameObject.FindGameObjectWithTag("notInTurn")).GetComponent<Status>().HP -= (GameObject.FindGameObjectWithTag("inTurn")).GetComponent<Status>().ATK;
            return;
        }else{
            (GameObject.FindGameObjectWithTag("inTurn")).GetComponent<Status>().HP -= (GameObject.FindGameObjectWithTag("notInTurn")).GetComponent<Status>().ATK;
            return;        
        }
    }

     
        
    
}
