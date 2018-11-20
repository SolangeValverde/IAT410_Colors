using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bars : MonoBehaviour
{
    //    Player playerFromClass;
    // Use this for initialization
    GameObject player;
    SpriteRenderer m_SpriteRenderer;
    //The Color to be assigned to the Renderer’s Material
    BoxCollider2D m_Collider;
    public GameObject[] bar;


    Color green, blue, red, yellow, MutedBlue, MutedGreen, MutedRed, MutedYellow;
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player")[0];
        // m_SpriteRenderer = player.GetComponent<SpriteRenderer>();

        m_Collider = GetComponent<BoxCollider2D>();


        bar = GameObject.FindGameObjectsWithTag("bar");


        green = new Color(0f, 0.784f, 0f, 1f);
        blue = new Color(0f, 0f, 0.784f, 1f);
        red = new Color(0.784f, 0f, 0f, 1f);
        yellow = new Color(0.784f, 0.784f, 0f, 1f);
        MutedBlue = new Color(0f, 0f, 0.384f, 1f);
        MutedGreen = new Color(0f, 0.384f, 0f, 1f);
        MutedRed = new Color(0.384f, 0f, 0f, 1f);
        MutedYellow = new Color(0.384f, 0.384f, 0f, 1f);

    }

    // Update is called once per frame
    void Update()
    {
        //if player changes color then they mute colors
        if (player.GetComponent<SpriteRenderer>().color == green)
        {
            // Debug.Log("player green " );
            for (int i = 0; i < bar.Length; i++)
            {
                // Debug.Log("checking bars ");
                if (bar[i].GetComponent<SpriteRenderer>().color.ToString() == blue.ToString())
                {
                    //     Debug.Log("muted blue");
                    bar[i].GetComponent<SpriteRenderer>().color = MutedBlue;
                    bar[i].GetComponent<BoxCollider2D>().enabled = false;

                }
                else if (bar[i].GetComponent<SpriteRenderer>().color.ToString() == red.ToString())
                {
                    //    Debug.Log("muted red");
                    bar[i].GetComponent<SpriteRenderer>().color = MutedRed;
                    bar[i].GetComponent<BoxCollider2D>().enabled = false;
                }

                else if (bar[i].GetComponent<SpriteRenderer>().color.ToString() == yellow.ToString())
                {
                    //   Debug.Log("muted yellow");
                    bar[i].GetComponent<SpriteRenderer>().color = MutedYellow;
                    bar[i].GetComponent<BoxCollider2D>().enabled = false;

                }
                else if (bar[i].GetComponent<SpriteRenderer>().color.ToString() == MutedGreen.ToString())
                {
                    //   Debug.Log("reg green");
                    bar[i].GetComponent<SpriteRenderer>().color = green;
                    bar[i].GetComponent<BoxCollider2D>().enabled = true;

                }

            }
        }
        if (player.GetComponent<SpriteRenderer>().color == blue)
        {
            //Debug.Log("player green " );
            for (int i = 0; i < bar.Length; i++)
            {
                // Debug.Log("checking bars ");
                if (bar[i].GetComponent<SpriteRenderer>().color.ToString() == MutedBlue.ToString())
                {
                    //    Debug.Log("muted blue");
                    bar[i].GetComponent<SpriteRenderer>().color = blue;
                    bar[i].GetComponent<BoxCollider2D>().enabled = true;

                }
                else if (bar[i].GetComponent<SpriteRenderer>().color.ToString() == red.ToString())
                {
                    //  Debug.Log("muted red");
                    bar[i].GetComponent<SpriteRenderer>().color = MutedRed;
                    bar[i].GetComponent<BoxCollider2D>().enabled = false;

                }

                else if (bar[i].GetComponent<SpriteRenderer>().color.ToString() == yellow.ToString())
                {
                    //  Debug.Log("muted yellow");
                    bar[i].GetComponent<SpriteRenderer>().color = MutedYellow;
                    bar[i].GetComponent<BoxCollider2D>().enabled = false;
                }
                else if (bar[i].GetComponent<SpriteRenderer>().color.ToString() == green.ToString())
                {
                    //  Debug.Log("reg green");
                    bar[i].GetComponent<SpriteRenderer>().color = MutedGreen;
                    bar[i].GetComponent<BoxCollider2D>().enabled = false;
                }
            }
        }
        if (player.GetComponent<SpriteRenderer>().color == red)
        {
            //Debug.Log("player green " );
            for (int i = 0; i < bar.Length; i++)
            {
                // Debug.Log("checking bars ");
                if (bar[i].GetComponent<SpriteRenderer>().color.ToString() == blue.ToString())
                {
                    //  Debug.Log("muted blue");
                    bar[i].GetComponent<SpriteRenderer>().color = MutedBlue;
                    bar[i].GetComponent<BoxCollider2D>().enabled = false;

                }
                else if (bar[i].GetComponent<SpriteRenderer>().color.ToString() == MutedRed.ToString())
                {
                    // Debug.Log("muted red");
                    bar[i].GetComponent<SpriteRenderer>().color = red;
                    bar[i].GetComponent<BoxCollider2D>().enabled = true;

                }

                else if (bar[i].GetComponent<SpriteRenderer>().color.ToString() == yellow.ToString())
                {
                    //  Debug.Log("muted yellow");
                    bar[i].GetComponent<SpriteRenderer>().color = MutedYellow;

                    bar[i].GetComponent<BoxCollider2D>().enabled = false;
                }
                else if (bar[i].GetComponent<SpriteRenderer>().color.ToString() == green.ToString())
                {
                    // Debug.Log("reg green");
                    bar[i].GetComponent<SpriteRenderer>().color = MutedGreen;
                    bar[i].GetComponent<BoxCollider2D>().enabled = false;

                }
            }
        }
        if (player.GetComponent<SpriteRenderer>().color == yellow)
        {
            //Debug.Log("player green " );
            for (int i = 0; i < bar.Length; i++)
            {
                // Debug.Log("checking bars ");
                if (bar[i].GetComponent<SpriteRenderer>().color.ToString() == blue.ToString())
                {
                    // Debug.Log("muted blue");
                    bar[i].GetComponent<SpriteRenderer>().color = MutedBlue;
                    bar[i].GetComponent<BoxCollider2D>().enabled = false;

                }
                else if (bar[i].GetComponent<SpriteRenderer>().color.ToString() == red.ToString())
                {
                    // Debug.Log("muted red");
                    bar[i].GetComponent<SpriteRenderer>().color = MutedRed;
                    bar[i].GetComponent<BoxCollider2D>().enabled = false;

                }

                else if (bar[i].GetComponent<SpriteRenderer>().color.ToString() == MutedYellow.ToString())
                {
                    // Debug.Log("muted yellow");
                    bar[i].GetComponent<SpriteRenderer>().color = yellow;
                    bar[i].GetComponent<BoxCollider2D>().enabled = true;

                }
                else if (bar[i].GetComponent<SpriteRenderer>().color.ToString() == green.ToString())
                {
                    // Debug.Log("reg green");
                    bar[i].GetComponent<SpriteRenderer>().color = MutedGreen;
                    bar[i].GetComponent<BoxCollider2D>().enabled = false;

                }
            }
        }


    }
    ///*


    void OnCollisionEnter2D(Collision2D collision)
    {
        //  bar = GameObject.FindGameObjectsWithTag("bar");
        //bar = this.gameObject;



        if (collision.gameObject.name != "bar")
        {
            //this.GetComponent<SpriteRenderer>().material.dynamicFriction = 1;
            for (int i = 0; i < bar.Length; i++)
            {

                if (this.GetComponent<SpriteRenderer>().color.ToString() == player.GetComponent<SpriteRenderer>().color.ToString())
                {

                    m_Collider.enabled = true;

                }
                else
                {
                    m_Collider.enabled = false;

                }
            }
        }

    }

    //  */

}
