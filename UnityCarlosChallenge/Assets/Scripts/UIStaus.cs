using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIStaus : MonoBehaviour
{
    public GameObject currentTurn;
    public TextMeshProUGUI currentHP, currentATK, currentDCS;


    void FixedUpdate()
    {
        currentTurn = GameObject.FindGameObjectWithTag("inTurn");
        
        currentHP.text = currentTurn.GetComponent<Status>().HP.ToString()+"HP";
        currentATK.text = currentTurn.GetComponent<Status>().ATK.ToString() +"ATK";
        currentDCS.text = currentTurn.GetComponent<Status>().DCS.ToString() +"DCS";
    }


}