using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        //PLAYER DIES IF FALL OFF THE PLATFORM
        if(gameObject.transform.position.y < -7)
        {
            Die();
        }
    }

    void Die()
    {
        //DEATH CODE
        SceneManager.LoadScene("Prototype_1");
    }
}
