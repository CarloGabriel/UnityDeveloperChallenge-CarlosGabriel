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
    


    void Update()
    {   
        if (Input.GetMouseButtonDown(0))
        {
            ClearToGo();
        }
        
        NearbyTerrain();
        CreatToGoTerrain();
        

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
                NearbyObj.Add(Allterrain[i]);
               
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


}
