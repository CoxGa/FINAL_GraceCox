using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;

public class PGrowTwo : MonoBehaviour
{

    private float PlantAlive = 6;

    public GameObject Key;

    //BOOLEANS
    public bool playerPick = true;

    public bool grow1 = true;

    public bool grow2 = false;

    public bool grow3 = false;

    public bool KeyOne = false;

    public bool CanWater = false;


    [SerializeField]
    private SpriteRenderer Sprite;

    public Sprite BreakPlant;

    public Sprite PlantGrow1;

    public Sprite PlantGrow2;

    public Sprite PlantGrow3;

    public Sprite PlantGrow4;

    public Sprite PlantGrow5;

    public Sprite PlantGrow6;

    public Sprite PlantGrow7;

    public Sprite PlantGrow8;

    public Sprite PlantGrow9;


    //PlantGROW
    void OnTriggerEnter2D(Collider2D other)
    {
        if (grow1)
        {

            if (this.gameObject.tag == "Plant1.1")
            {

                Sprite.sprite = PlantGrow1;
            }

            if (this.gameObject.tag == "Plant1.2")
            {

                Sprite.sprite = PlantGrow2;
            }

            if (this.gameObject.tag == "Plant1.3")
            {

                Sprite.sprite = PlantGrow3;
            }

            grow1 = false;
            grow2 = true;
        }
        else

        if (grow2)
        {
            if (this.gameObject.tag == "Plant1.1")
            {

                Sprite.sprite = PlantGrow4;
            }

            if (this.gameObject.tag == "Plant1.2")
            {

                Sprite.sprite = PlantGrow5;
            }

            if (this.gameObject.tag == "Plant1.3")
            {

                Sprite.sprite = PlantGrow6;
            }

            grow2 = false;
            grow3 = true;
        }

        else

        if (grow3)
        {

            if (this.gameObject.tag == "Plant1.1")
            {
                KeyOne = true;
                Sprite.sprite = PlantGrow7;


            }

            if (this.gameObject.tag == "Plant1.2")
            {

                KeyOne = true;
                Sprite.sprite = PlantGrow8;


            }

            if (this.gameObject.tag == "Plant1.3")
            {


                KeyOne = true;
                Sprite.sprite = PlantGrow9;


            }


        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            Sprite.sprite = BreakPlant;
            Destroy(this.gameObject, 0.2f);

        }
    }


}

