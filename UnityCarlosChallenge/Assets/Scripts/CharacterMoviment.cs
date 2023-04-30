using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoviment : MonoBehaviour
{
  

   

    void OnMouseDown()
    {
        GameObject PlayerToMove = GameObject.Find ("DogPolyart"); 
        PlayerToMove.transform.position = new Vector3(-3.495f,1f,-4.511f);
         
    }
}
