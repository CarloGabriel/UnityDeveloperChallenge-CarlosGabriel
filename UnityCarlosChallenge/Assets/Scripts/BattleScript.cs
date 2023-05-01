using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleScript : MonoBehaviour
{
    public int[] danoS;
    public int[] danoF;

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

}
