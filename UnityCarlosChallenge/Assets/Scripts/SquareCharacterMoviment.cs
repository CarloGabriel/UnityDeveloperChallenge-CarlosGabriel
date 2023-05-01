using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SquareCharacterMoviment : MonoBehaviour
{
    GameObject[] itens;

    public void OnMouseDown()

    {

        GameObject PlayerToMove = GameObject.FindGameObjectWithTag("inTurn"); 
        PlayerToMove.transform.position = new Vector3(transform.position.x,0.2f,transform.position.z);
        PlayerToMove.transform.rotation = Quaternion.identity;

        itens = GameObject.FindGameObjectsWithTag("item"); 

        for (int i = 0; i < itens.Length; i++)
        {
            
            if(itens[i].transform.position.x == transform.position.x && itens[i].transform.position.z == transform.position.z)
            {
                Destroy(itens[i]);
            }
             
        }

    }

}


