using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoSpwan : MonoBehaviour
{
 [SerializeField] public GameObject logo;
 [SerializeField] public float spawnTime;
 private Vector3 currentResetPostion;
 void Start () {
     currentResetPostion = transform.position;
     InvokeRepeating ("LogoReset", spawnTime, spawnTime);
     
 }
    
 void LogoReset()
 {
     transform.position = currentResetPostion;
 }
 
 }