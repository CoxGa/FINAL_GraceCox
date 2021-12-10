using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
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


    bool play2 = false;

    // Start is called before the first frame update
    void Start()
    {

        SpawnPlants();

    }

        // Update is called once per frame
        void Update()
        {
        
        
        }
    


   public void SpawnPlants()
    {
        GameObject[] ArrayList = { plantPrefab1,plantPrefab2, plantPrefab3};
        
            
        Instantiate(ArrayList[Random()], new Vector3(2, -1, 0), Quaternion.identity);
        Instantiate(ArrayList[Random()], new Vector3(5, -1, 0), Quaternion.identity);
        Instantiate(ArrayList[Random()], new Vector3(-16, 3, 0), Quaternion.identity);
        Instantiate(ArrayList[Random()], new Vector3(-13, 3, 0), Quaternion.identity);
        Instantiate(ArrayList[Random()], new Vector3(9, 8, 0), Quaternion.identity);
        Instantiate(ArrayList[Random()], new Vector3(13, 8, 0), Quaternion.identity);


    }

    private int Random()
    {
        return UnityEngine.Random.Range(0, 3);

    }

    
}
