using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;

using UnityEngine.SceneManagement;

public class PressStart : MonoBehaviour
{



    public void OnSpace(InputValue value)
    {

           
            SceneManager.LoadScene("Tutorial");

            Destroy(this.gameObject);
        
    }

   
}
