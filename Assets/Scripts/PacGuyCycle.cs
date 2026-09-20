// using System.Numerics;
using System;
using System.Data;
using Unity.Mathematics;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PacGuyCycle : MonoBehaviour
{
    private Vector3[] positions;
    private int idx;
    private float t;
    private Vector3 CurrentPos;
    private Vector3 newPos;
    public Animator PacGuy;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        PacGuy = gameObject.GetComponent<Animator>();

        transform.position.Set(-11.5f,8.5f,0f);

        idx = 0;

        positions = new Vector3[4];

        positions[0] = new Vector3(-11.5f,12.5f,0f);
        positions[1] = new Vector3(-11.5f,8.5f,0f);
        positions[2] = new Vector3(-16.5f,8.5f,0f);
        positions[3] = new Vector3(-16.5f,12.5f,0f);

        t = 0f;

    }

    // Update is called once per frame
    void Update()
    {
        // CurrentPos = transform.position;
        
        t += Time.fixedDeltaTime;
        idx = (int)t % 4;
        // Debug.Log("t: " + t + "idx: " + idx);
        // newPos = Vector3.Lerp(positions[idx % 4], positions[(idx + 1) % 4],t % 1.0f);

        // transform.position = newPos;
        // CurrentPos = newPos;

            if (idx == 0)  {

            PacGuy.SetTrigger("Down");
            newPos = Vector3.Lerp(positions[0],positions[1],t % 1.0f);
            transform.position = newPos;


        }   else if (idx == 1)
        {
            PacGuy.SetTrigger("Left");
            newPos = Vector3.Lerp(positions[1],positions[2],t % 1.0f);
            transform.position = newPos;
  

        }   else if (idx == 2)
        {
            PacGuy.SetTrigger("Up");
            newPos = Vector3.Lerp(positions[2],positions[3],t % 1.0f);
            transform.position = newPos;


        }  else if (idx == 3)
        {
            PacGuy.SetTrigger("Right");
            newPos = Vector3.Lerp(positions[3],positions[0],t % 1.0f);
            transform.position = newPos;

        }

    }

}
