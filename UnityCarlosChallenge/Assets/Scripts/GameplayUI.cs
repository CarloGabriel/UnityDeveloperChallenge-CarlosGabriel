using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameplayUI : MonoBehaviour
{
    public GameObject currentTurn;
    public int countS;
    public TextMeshProUGUI currentPlayer;
    public TextMeshProUGUI currentTurnString;

    void Update()
    {
        currentTurn = GameObject.FindGameObjectWithTag("inTurn");

        currentTurnString.text = (countS+1).ToString();

        if (Input.GetMouseButtonDown(0))
        {
            countS+=1;
            if(countS == 3)
            {
                countS = 0;
            }
        }

        currentPlayer.text = currentTurn.name;
        
    }


}
