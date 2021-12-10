using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GManTwo : MonoBehaviour
{

    [SerializeField]
    private GameObject prefab;

    public GameObject Key;

    public bool KeyOn = false;

    [SerializeField]
    private GameObject plantPrefab1 = null;

    [SerializeField]
    private GameObject plantPrefab2 = null;

    [SerializeField]
    private GameObject plantPrefab3 = null;



    //public var switchScript;

    bool play2 = false;

    void Start()
    {

        SpawnPlants();

    }

    // Update is called once per frame
    void Update()
    {

        if (GameObject.FindObjectOfType<PGrowTwo>() == null)
        {
            
            SpawnKey();
        }
        else
        {

        }
    }


    public void SpawnKey()
    {
        if (!KeyOn)
        {
            Debug.Log("KEY APPEARS");
            Instantiate(Key, new Vector3(0, 0, 0), Quaternion.identity);
            KeyOn = true;
        }

    }

    public void SpawnPlants()
    {
        GameObject[] ArrayList = { plantPrefab1, plantPrefab2, plantPrefab3 };


        Instantiate(ArrayList[Random()], new Vector3(-15, -6, 0), Quaternion.identity);
        Instantiate(ArrayList[Random()], new Vector3(-13, -6, 0), Quaternion.identity);
        Instantiate(ArrayList[Random()], new Vector3(15, 2, 0), Quaternion.identity);
        Instantiate(ArrayList[Random()], new Vector3(17, 2, 0), Quaternion.identity);
        Instantiate(ArrayList[Random()], new Vector3(-5, 7, 0), Quaternion.identity);
        Instantiate(ArrayList[Random()], new Vector3(-6, 7, 0), Quaternion.identity);


    }

    private int Random()
    {
        return UnityEngine.Random.Range(0, 3);

    }


}

