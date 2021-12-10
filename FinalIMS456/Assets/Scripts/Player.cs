using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public enum PlayerNumber { PlayerOne, PlayerTwo }

    [SerializeField]
    private Rigidbody2D rigidb;

    [SerializeField]
    private float speed;

    [SerializeField]
    private PlayerInput playerInput;

    [SerializeField]
    private SpriteRenderer meshRenderer;


    private Vector3 direction;

    public GameObject WaterCan;

    public Sprite Idle;

    public Sprite Flying;

    public Sprite Dying;

    public Vector2 moveInput;

    public bool right = false;

    public bool left = false;

    private float thrust = 100000.0f;

    public float start = 0;

    float timeSinceLastJump = 0;

    public GameObject Key;

    public bool KeyOn = false;

    // Start is called before the first frame update
    void Start()
    {

        meshRenderer.flipX = false;
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastJump += Time.deltaTime;

        if (left)
        {
     
            meshRenderer.flipX = false;
        }

        if (right)
        {
            meshRenderer.flipX = true;
        
        }
    }

    private void FixedUpdate()
    {

        rigidb.MovePosition(transform.position + (direction * speed * Time.deltaTime));

        

    }

    public void OnMove(InputValue value)
    {
        Debug.Log("Move: " + value.Get<Vector2>());
        
        var dir = value.Get<Vector2>();
        direction.x = dir.x;

        if (direction.x == -1)
        {
            left = true;
            right = false;

        }

        if (direction.x == 1)
        {
            right = true;
            left = false;
        }


    }

    public void OnJump(InputValue value) 
    {

        var dir = value.Get<Vector2>();
        
        direction.y = dir.y;

        meshRenderer.sprite = Flying;



    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        meshRenderer.sprite = Idle;

        if (collision.gameObject.tag == "Shelf")
        {
        meshRenderer.sprite = Flying;

        }

        if (collision.gameObject.tag == "Edge")
        {
            meshRenderer.sprite = Flying;

        }

        if (collision.gameObject.tag == "Table")
        {
            if (!KeyOn)
            {
                Instantiate(Key, new Vector3(0, 0, 0), Quaternion.identity);
                KeyOn = true;
            }

        }

    }



}
