using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changingColors : MonoBehaviour
{

    Color[] colors = new Color[4];

    void Start()
    {
        StartCoroutine (changeColor ());
        colors[0] = new Color(0f, 0f, 0.384f, 1f);
        colors[1] = new Color(0f, 0.384f, 0f, 1f);
        colors[2] = new Color(0.384f, 0f, 0f, 1f);
        colors[3] = new Color(0.384f, 0.384f, 0f, 1f);
    }

    void Update()
    {

    }


    IEnumerator changeColor()
    {
        while (true)
        {
            

                gameObject.GetComponent<SpriteRenderer>().color = colors[0];
                //gameObject.GetComponent<SpriteRenderer>().color = colors[Random.Range(0, colors.Length)];
                yield return new WaitForSeconds(4.0f);
                gameObject.GetComponent<SpriteRenderer>().color = colors[1];
                yield return new WaitForSeconds(4.0f);
                gameObject.GetComponent<SpriteRenderer>().color = colors[2];
                yield return new WaitForSeconds(4.0f);
                gameObject.GetComponent<SpriteRenderer>().color = colors[3];
                yield return new WaitForSeconds(4.0f);
            
        }
    }
}