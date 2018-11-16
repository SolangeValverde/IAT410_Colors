using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verticalMovingBars : MonoBehaviour
{

    Vector3 temp;
    // Use this for initialization
    public bool ChangingColor;
    public float delta = 4f;  // Amount to move left and right from the start point
    public float speed = 2.0f;
    private Vector3 startPos;

    Color[] colors = new Color[4];

    void Start()
    {
        startPos = transform.position;
       // StartCoroutine (changeColor ());
        colors[0] = new Color(0f, 0f, 0.384f, 1f);
        colors[1] = new Color(0f, 0.384f, 0f, 1f);
        colors[2] = new Color(0.384f, 0f, 0f, 1f);
        colors[3] = new Color(0.384f, 0.384f, 0f, 1f);
    }

    void Update()
    {
        Vector3 v = startPos;
        v.y += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
        

    }


}

