using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndLevel : MonoBehaviour
{

    public Text Win;
    
        void OnTriggerEnter2D(Collider2D col)
        {
            //WIN CODE
            if (col.CompareTag("Player"))
            {
            Win.gameObject.SetActive(true);
            }
        }
}
