using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;

public class WaterCan : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;

   public GameObject Player;

    public bool playerPick = false;

    [SerializeField]
    private Vector3 pos;

    [SerializeField]
    private float speed;

    [SerializeField]
    private SpriteRenderer meshRenderer;
    
    public bool right = false;

    public bool left = false;

    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }


    

    void Update()
    {
        //Vector3 PlayerPos = Player.gameObject.transform.position;

        if (playerPick)
        {
            Vector2 PlayerTar = Player.transform.position;
            
            float Ymove = 1f;
            
            transform.position = new Vector3(PlayerTar.x -1, PlayerTar.y + Ymove, -1);
            


        }

    }




    //private void OnTriggerEnter2D(Collider2D collision)
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("PLAYER HIT");
            playerPick = true;


        }
    }


}
