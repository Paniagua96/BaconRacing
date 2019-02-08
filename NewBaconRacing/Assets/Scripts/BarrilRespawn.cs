using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrilRespawn : MonoBehaviour
{
    public int numRandomPlayer1;
    public int numRandomPlayer2;

    public void Start()
    {
        numRandomPlayer1 = 0;
        numRandomPlayer2 = 0;
    }

    public void OnTriggerEnter(Collider other)
    {
       
        StartCoroutine(DisapearBarrilForSeconds());
        if (other == CompareTag("player1"))
        {
            numRandomPlayer1 = GetNumItemRandom(numRandomPlayer1);
        }else if (other == CompareTag("player2"))
        {
            numRandomPlayer2 = GetNumItemRandom(numRandomPlayer2);
        }
        
    }

    public IEnumerator DisapearBarrilForSeconds()
    {
       this.transform.position=new Vector3(this.transform.position.x,this.transform.position.y-10);
        yield return new WaitForSeconds(3);
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y +10);

    }

    public int GetNumItemRandom(int _numRandom)
    {
        _numRandom = Random.Range(1, 5);
        Debug.Log(_numRandom);
        return _numRandom;
    }
}
