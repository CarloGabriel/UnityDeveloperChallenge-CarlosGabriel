using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexagonCharacterMoviment : MonoBehaviour
{
  
    void OnMouseDown()
    {
        GameObject PlayerToMove = GameObject.Find ("DogPolyart"); 
        PlayerToMove.transform.position = new Vector3(transform.position.x,-1f,transform.position.z);
        PlayerToMove.transform.rotation = Quaternion.identity;
    }
}
