using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class TDoorTwo : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer Sprite;


    public Sprite Open;

 

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Key")
        {
            Sprite.sprite = Open;

            SceneManager.LoadScene("ThirdRoom");

        }
    }


}

