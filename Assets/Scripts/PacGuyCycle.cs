// using System.Numerics;
using System;
using System.Data;
using Unity.Collections;
using Unity.Mathematics;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Rendering;

public class PacGuyCycle : MonoBehaviour
{
    private Vector3[] positions;
    private int idx;
    private float t;
    private Vector3 newPos;
    private Animator PacGuy;
    private const String xhori = "Horizontal";
    private const String yvert = "Vertical";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        PacGuy = gameObject.GetComponent<Animator>();

        transform.position.Set(-11.5f,8.5f,0f);

        idx = 0;

        positions = new Vector3[5];

        positions[0] = new Vector3(-11.5f,12.5f,0f);
        positions[1] = new Vector3(-11.5f,8.5f,0f);
        positions[2] = new Vector3(-16.5f,8.5f,0f);
        positions[3] = new Vector3(-16.5f,12.5f,0f);
        positions[4] = new Vector3(-11.5f,12.5f,0f);
        t = 0f;

    }

    // Update is called once per frame
    void Update()
    {
        
        t += Time.fixedDeltaTime / 2;
        idx = (int)t % 4;

  
        PacGuy.SetFloat(xhori,positions[idx + 1].x - positions[idx].x);
        PacGuy.SetFloat(yvert,positions[idx + 1].y - positions[idx].y);


            if (idx == 0)  {


            newPos = Vector3.Lerp(positions[0],positions[1],t % 1.0f);
            transform.position = newPos;


        }   else if (idx == 1)
        {

            newPos = Vector3.Lerp(positions[1],positions[2],t % 1.0f);
            transform.position = newPos;
  

        }   else if (idx == 2)
        {
            newPos = Vector3.Lerp(positions[2],positions[3],t % 1.0f);
            transform.position = newPos;


        }  else if (idx == 3)
        {
            
            newPos = Vector3.Lerp(positions[3],positions[0],t % 1.0f);
            transform.position = newPos;

        }

    }


}
