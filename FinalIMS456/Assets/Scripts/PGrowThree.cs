using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.SceneManagement;

public class PGrowThree : MonoBehaviour
{

    //BOOLEANS
    bool grow1 = true;

    bool grow2 = false;

    bool grow3 = false;

    [SerializeField]
    private SpriteRenderer Sprite;


    public Sprite PlantGrow1;

    public Sprite PlantGrow2;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (grow1)
        {

            if (this.gameObject.tag == "Plant1.1")
            {

                Sprite.sprite = PlantGrow1;
            }



            grow1 = false;
            grow2 = true;
        }
        else

        if (grow2)
        {
            if (this.gameObject.tag == "Plant1.1")
            {

                Sprite.sprite = PlantGrow2;
            }


            grow2 = false;
            grow3 = true;
        }

        else
        {


            if (grow3)
            {

                SceneManager.LoadScene("End");
            }
        }
    }
    
    }
