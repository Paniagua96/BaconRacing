using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class ItemControl : MonoBehaviour
{

    public GameObject item1TocinoPista;
    public GameObject item3ManchaPantallaEnemigo;
   
    public void ChargeItem(int _numRandom)
    {

        _numRandom = Random.Range(1, 5);

        switch (_numRandom)
        {
            case 1:
                PoderItem1();
                break;
            case 2:
                PoderItem2();
                break;
            case 3:
                PoderItem3();
                break;

            case 4:
                PoderItem2();
                break;
 
            default:
                Debug.Log("No hay Nada");
                break;

        }
    }


    //Poder de dejar un tocino en la pista

    public void PoderItem1()
    {

        Instantiate(item1TocinoPista, transform.position, transform.rotation);

    }


    //Poder escudo cerdo
    public void PoderItem2()
    {

        StartCoroutine(TiempoItem2());
        Debug.Log("Se activo el item2");
    }

    IEnumerator TiempoItem2()
    {

        transform.localScale = new Vector3(this.transform.position.x*1.2f, this.transform.position.y *1.2f, this.transform.position.z *1.2f);

        yield return new WaitForSeconds(5);

        transform.localScale = new Vector3(this.transform.position.x /.2f, this.transform.position.y / 1.2f, this.transform.position.z / 1.2f);

    }

    //Item 3 mancha pantalla del enemigo

    public void PoderItem3()
    {
        StartCoroutine(TiempoItem3());
    }

    IEnumerator TiempoItem3()
    {
        item3ManchaPantallaEnemigo.SetActive(true);
        yield return new WaitForSeconds(5);
        item3ManchaPantallaEnemigo.SetActive(false);

    }


    //Item 4 Aceleracion del personaje

    //public void PoderItem4()
    //{
    //    StartCoroutine(TiempoItem4());
    //}

    //IEnumerator TiempoItem4()
    //{
    //    GameControl.velocidad1 = 8.0f;
    //    GameControl.maxSpeed1 = 8.0f;
    //    yield return new WaitForSeconds(5);
    //    GameControl.velocidad1 = 1.0f;
    //    GameControl.maxSpeed1 = 5.0f;
    //}



}
