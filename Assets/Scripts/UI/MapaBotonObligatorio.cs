using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapaBotonObligatorio : MonoBehaviour
{
    //GameManager gm;
    public GameObject Deuda;    
    
    //void Start()
    //{
    //    gm = GameObject.FindObjectOfType<GameManager>();
    //}

    public void Unlock (int deuda)
    {
        if(GameManager.ahorros >= deuda)
        {
            GameManager.ahorros -= deuda;
            gameObject.GetComponent<Button>().interactable = true;
            GameManager.paidDeudas += 1;
            GameManager.instance.SaveData();
            Deuda.SetActive(false);
        }
        else
        {
            Deuda.GetComponent<Button>().interactable = false;
        }
    }
}
