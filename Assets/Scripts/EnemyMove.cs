using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class EnemyMove : MonoBehaviour
{
    public int EnemySpeed;
    public int XMoveDirection;

    // Update is called once per frame
    void Update()
    {
        //ENEMY MOVE
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(XMoveDirection, 0) * EnemySpeed;
        
        //DAMAGE TO PLAYER IF COLLIDE
        RaycastHit2D hit = Physics2D.Raycast (transform.position, new Vector2(XMoveDirection, 0));
        if (hit.collider.CompareTag("Player") && hit.distance < 0.9f)
        {
            SceneManager.LoadScene("Prototype_1");
        }
    }
}
