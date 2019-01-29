using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatorObjects : MonoBehaviour
{

    public GameObject track;
    public GameObject player;
    public GameObject ui;

    public void Start()
    {
        StartCoroutine(createRace());

    }

    IEnumerator createRace()
    {

        Instantiate(track);

        yield return new WaitForSeconds(3);

        Instantiate(ui);
        Instantiate(player);

    }
    
}
