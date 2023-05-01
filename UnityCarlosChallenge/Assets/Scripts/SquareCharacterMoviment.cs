using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SquareCharacterMoviment : MonoBehaviour
{
    

    public void OnMouseDown()

    {

        GameObject PlayerToMove = GameObject.FindGameObjectWithTag("inTurn"); 
        PlayerToMove.transform.position = new Vector3(transform.position.x,0.2f,transform.position.z);
        PlayerToMove.transform.rotation = Quaternion.identity;
        

    }

}
