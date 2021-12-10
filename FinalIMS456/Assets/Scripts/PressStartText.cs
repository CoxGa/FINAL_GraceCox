using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.InputSystem;

using UnityEngine.SceneManagement;


public class PressStartText : MonoBehaviour
{


    public void OnSpace(InputValue value)
    {

        Debug.Log("NEXT ROOM");


        SceneManager.LoadScene("FirstRoom");

      

    }
}
