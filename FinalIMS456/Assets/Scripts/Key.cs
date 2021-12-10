using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject Player;

    public bool playerPick = false;

    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("PLAYER HIT");
            playerPick = true;

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerPick)
        {
            Vector2 PlayerTar = Player.transform.position;
            

            float Ymove = 2;

            transform.position = new Vector3(PlayerTar.x -2f, PlayerTar.y + Ymove, 0);




        }
    }
}
