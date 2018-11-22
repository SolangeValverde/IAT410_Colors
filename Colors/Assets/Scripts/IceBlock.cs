using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBlock : MonoBehaviour
{
    public GameObject Player;
    public bool OnIce = false;
    private Rigidbody2D rb;
    private float timer;

    void Start()
    {
        rb = Player.GetComponent<Rigidbody2D>();

    }

    void Update()
    {



    }
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == "Player")
        {
            Vector3 v = new Vector3(10, 0, 0);
            rb.drag = 0;
            timer = 0;
            timer += Time.deltaTime;
            Debug.Log(timer);
            if (Player.GetComponent<Player>().goingRight)
            {

                Player.transform.position += v * Time.deltaTime;
            }
            else
            {
                Player.transform.position -= v * Time.deltaTime;
            }

            OnIce = true;
            //  Player.GetComponent<Collider>().material.dynamicFriction = 0;
            // Debug.Log("drag " + Player.GetComponent<Rigidbody2D>().drag);


        }

    }
    void OnCollisionExit2D(Collision2D collision)
    {

        if (collision.gameObject.name == "Player")
        {

            OnIce = false;


        }

    }



}

