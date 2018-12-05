using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        
        if (Input.GetKeyDown("space") )
        {
         
            Debug.Log("SceneManager.GetActiveScene().buildIndex " + SceneManager.GetActiveScene().buildIndex);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
       
    }





}





