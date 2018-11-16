using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBars : MonoBehaviour
{
    GameObject player;
    SpriteRenderer m_SpriteRenderer;
    //The Color to be assigned to the Renderer’s Material
    BoxCollider2D m_Collider;
    public GameObject[] MovingBar;
    Vector3 temp;
    // Use this for initialization

    public float delta = 4f;  // Amount to move left and right from the start point
    public float speed = 2.0f;
    private Vector3 startPos;
    bool onMovingBar = false;
    Color green, blue, red, yellow, MutedBlue, MutedGreen, MutedRed, MutedYellow;
    void Start()
    {
        startPos = transform.position;

        player = GameObject.FindGameObjectsWithTag("Player")[0];
        // m_SpriteRenderer = player.GetComponent<SpriteRenderer>();

        m_Collider = GetComponent<BoxCollider2D>();


        MovingBar = GameObject.FindGameObjectsWithTag("MovingBar");


        green = new Color(0f, 0.784f, 0f, 1f);
        blue = new Color(0f, 0f, 0.784f, 1f);
        red = new Color(0.784f, 0f, 0f, 1f);
        yellow = new Color(0.784f, 0.784f, 0f, 1f);
        MutedBlue = new Color(0f, 0f, 0.384f, 1f);
        MutedGreen = new Color(0f, 0.384f, 0f, 1f);
        MutedRed = new Color(0.384f, 0f, 0f, 1f);
        MutedYellow = new Color(0.384f, 0.384f, 0f, 1f);
    }

    void Update()
    {
        Vector3 v = startPos;
        v.x += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;

        // Debug.Log("v " + v.x + " speed " + speed + " math?: " + Mathf.Sin(Time.time * speed));
        // Debug.Log("player pos " + player.transform.position.x);
        // //Debug.Log("what would be posX+speed: "+ player.transform.position.x + speed);
        // Debug.Log("rb velocity " + player.GetComponent<Rigidbody2D>().velocity);
        //if player changes color then they mute colors
        if (player.GetComponent<SpriteRenderer>().color == green)
        {
            // Debug.Log("player green " );
            for (int i = 0; i < MovingBar.Length; i++)
            {
                // Debug.Log("checking bars ");
                if (MovingBar[i].GetComponent<SpriteRenderer>().color.ToString() == blue.ToString())
                {
                    //     Debug.Log("muted blue");
                    MovingBar[i].GetComponent<SpriteRenderer>().color = MutedBlue;
                    MovingBar[i].GetComponent<BoxCollider2D>().enabled = false;

                }
                else if (MovingBar[i].GetComponent<SpriteRenderer>().color.ToString() == red.ToString())
                {
                    //    Debug.Log("muted red");
                    MovingBar[i].GetComponent<SpriteRenderer>().color = MutedRed;
                    MovingBar[i].GetComponent<BoxCollider2D>().enabled = false;
                }

                else if (MovingBar[i].GetComponent<SpriteRenderer>().color.ToString() == yellow.ToString())
                {
                    //   Debug.Log("muted yellow");
                    MovingBar[i].GetComponent<SpriteRenderer>().color = MutedYellow;
                    MovingBar[i].GetComponent<BoxCollider2D>().enabled = false;

                }
                else if (MovingBar[i].GetComponent<SpriteRenderer>().color.ToString() == MutedGreen.ToString())
                {
                    //   Debug.Log("reg green");
                    MovingBar[i].GetComponent<SpriteRenderer>().color = green;
                    MovingBar[i].GetComponent<BoxCollider2D>().enabled = true;

                }

            }
        }
        if (player.GetComponent<SpriteRenderer>().color == blue)
        {
            //Debug.Log("player green " );
            for (int i = 0; i < MovingBar.Length; i++)
            {
                // Debug.Log("checking bars ");
                if (MovingBar[i].GetComponent<SpriteRenderer>().color.ToString() == MutedBlue.ToString())
                {
                    //    Debug.Log("muted blue");
                    MovingBar[i].GetComponent<SpriteRenderer>().color = blue;
                    MovingBar[i].GetComponent<BoxCollider2D>().enabled = true;

                }
                else if (MovingBar[i].GetComponent<SpriteRenderer>().color.ToString() == red.ToString())
                {
                    //  Debug.Log("muted red");
                    MovingBar[i].GetComponent<SpriteRenderer>().color = MutedRed;
                    MovingBar[i].GetComponent<BoxCollider2D>().enabled = false;

                }

                else if (MovingBar[i].GetComponent<SpriteRenderer>().color.ToString() == yellow.ToString())
                {
                    //  Debug.Log("muted yellow");
                    MovingBar[i].GetComponent<SpriteRenderer>().color = MutedYellow;
                    MovingBar[i].GetComponent<BoxCollider2D>().enabled = false;
                }
                else if (MovingBar[i].GetComponent<SpriteRenderer>().color.ToString() == green.ToString())
                {
                    //  Debug.Log("reg green");
                    MovingBar[i].GetComponent<SpriteRenderer>().color = MutedGreen;
                    MovingBar[i].GetComponent<BoxCollider2D>().enabled = false;
                }
            }
        }
        if (player.GetComponent<SpriteRenderer>().color == red)
        {
            //Debug.Log("player green " );
            for (int i = 0; i < MovingBar.Length; i++)
            {
                // Debug.Log("checking bars ");
                if (MovingBar[i].GetComponent<SpriteRenderer>().color.ToString() == blue.ToString())
                {
                    //  Debug.Log("muted blue");
                    MovingBar[i].GetComponent<SpriteRenderer>().color = MutedBlue;
                    MovingBar[i].GetComponent<BoxCollider2D>().enabled = false;

                }
                else if (MovingBar[i].GetComponent<SpriteRenderer>().color.ToString() == MutedRed.ToString())
                {
                    // Debug.Log("muted red");
                    MovingBar[i].GetComponent<SpriteRenderer>().color = red;
                    MovingBar[i].GetComponent<BoxCollider2D>().enabled = true;

                }

                else if (MovingBar[i].GetComponent<SpriteRenderer>().color.ToString() == yellow.ToString())
                {
                    //  Debug.Log("muted yellow");
                    MovingBar[i].GetComponent<SpriteRenderer>().color = MutedYellow;

                    MovingBar[i].GetComponent<BoxCollider2D>().enabled = false;
                }
                else if (MovingBar[i].GetComponent<SpriteRenderer>().color.ToString() == green.ToString())
                {
                    // Debug.Log("reg green");
                    MovingBar[i].GetComponent<SpriteRenderer>().color = MutedGreen;
                    MovingBar[i].GetComponent<BoxCollider2D>().enabled = false;

                }
            }
        }
        if (player.GetComponent<SpriteRenderer>().color == yellow)
        {
            //Debug.Log("player green " );
            for (int i = 0; i < MovingBar.Length; i++)
            {
                // Debug.Log("checking bars ");
                if (MovingBar[i].GetComponent<SpriteRenderer>().color.ToString() == blue.ToString())
                {
                    // Debug.Log("muted blue");
                    MovingBar[i].GetComponent<SpriteRenderer>().color = MutedBlue;
                    MovingBar[i].GetComponent<BoxCollider2D>().enabled = false;

                }
                else if (MovingBar[i].GetComponent<SpriteRenderer>().color.ToString() == red.ToString())
                {
                    // Debug.Log("muted red");
                    MovingBar[i].GetComponent<SpriteRenderer>().color = MutedRed;
                    MovingBar[i].GetComponent<BoxCollider2D>().enabled = false;

                }

                else if (MovingBar[i].GetComponent<SpriteRenderer>().color.ToString() == MutedYellow.ToString())
                {
                    // Debug.Log("muted yellow");
                    MovingBar[i].GetComponent<SpriteRenderer>().color = yellow;
                    MovingBar[i].GetComponent<BoxCollider2D>().enabled = true;

                }
                else if (MovingBar[i].GetComponent<SpriteRenderer>().color.ToString() == green.ToString())
                {
                    // Debug.Log("reg green");
                    MovingBar[i].GetComponent<SpriteRenderer>().color = MutedGreen;
                    MovingBar[i].GetComponent<BoxCollider2D>().enabled = false;

                }
            }
        }

        if (onMovingBar)
        {
            //player.transform.localScale = new Vector3(0.3F, 3.4F, 0.4F);
            Debug.Log("scale: "+ player.transform.localScale);
            // Vector3 zero =  player.GetComponent<Rigidbody2D>().velocity;
            // zero.y =0;
            // zero.x =0;
            // player.GetComponent<Rigidbody2D>().velocity = zero;

            // Vector3 vP = player.transform.position;
            // vP.x += startPos.x + delta * Mathf.Sin(Time.time * speed);
            // vP.y = player.transform.position.y;
            // player.transform.position = vP;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        // print("No longer in contact with " + other.transform.name);
        other.collider.transform.SetParent(null);
       // onMovingBar = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //  Debug.Log("On moving bar");
        //  if (this.gameObject.tag == "Player")
        // {
        collision.collider.transform.SetParent(transform);
        // }
        //   player.transform.parent = this.gameObject.transform;
        onMovingBar = true;
        if (collision.gameObject.name != "MovingBar")
        {
            for (int i = 0; i < MovingBar.Length; i++)
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


}