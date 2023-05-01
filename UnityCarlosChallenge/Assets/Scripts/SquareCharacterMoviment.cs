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
                if(itens[i].name == "HP(Clone)")
                {
                    if (PlayerToMove.GetComponent<Status>().HP<PlayerToMove.GetComponent<Status>().BaHP)
                    {
                       PlayerToMove.GetComponent<Status>().HP += 1; 
                    }
                    
                }
                if(itens[i].name == "HP Legendary(Clone)")
                {
                    if (PlayerToMove.GetComponent<Status>().HP <= (PlayerToMove.GetComponent<Status>().BaHP-2))
                    {
                       PlayerToMove.GetComponent<Status>().HP += 2; 
                    }
                   
                }
                if(itens[i].name == "ExtraDices(Clone)")
                {
                    PlayerToMove.GetComponent<Status>().DCS += 1;

                }
                if(itens[i].name == "ExtraDices Legendary(Clone)")
                {
                    PlayerToMove.GetComponent<Status>().DCS += 2;
                }
                if(itens[i].name == "Sword(Clone)")
                {
                    PlayerToMove.GetComponent<Status>().ATK += 1;
                }
                if(itens[i].name == "Sword Legendary(Clone)")
                {
                    PlayerToMove.GetComponent<Status>().ATK += 2;
                }
                Destroy(itens[i]);

            }
             
        }

        GameObject PlayerToNotMove = GameObject.FindGameObjectWithTag("notInTurn");
        PlayerToNotMove.GetComponent<Status>().DCS = PlayerToNotMove.GetComponent<Status>().BaDCS;
        PlayerToNotMove.GetComponent<Status>().ATK = PlayerToNotMove.GetComponent<Status>().BaATK;
    }
}


