using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class ItemControl : MonoBehaviour
{
    private BarrilRespawn barrilRespawn;

    private GameObject Player1, Player2;
    public int numItem1,numItem2;
    public bool item1IsActive, item2IsActive;

    public void Start()
    {
        Player1=GameObject.FindWithTag("player1");
        Player2 = GameObject.FindWithTag("player2");

        numItem1 = barrilRespawn.numRandomPlayer1;
        numItem2 = barrilRespawn.numRandomPlayer2;
    }

    public void Update()
    {
        if (numItem1 != 0)
        {
            GetItemPower(numItem1);
        }else if(numItem2!=0)
        {
            GetItemPower(numItem2);
        }


    }


    public void GetItemPower(int _numItem)
    {
        switch (_numItem)
        {
            case 1:

                break;
            case 2:

                break;
            case 3:

                break;
            case 4:

                break;
            case 5:

                break;
        }


    }


}
