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

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
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
        CurrentPos = transform.position;
        
        t += Time.fixedDeltaTime;
        idx = (int)t;
        Debug.Log("t: " + t + "idx: " + idx);
        newPos = Vector3.Lerp(positions[idx % 4], positions[(idx + 1) % 4],t % 1.0f);

        transform.position = newPos;


    }

}
