// using System.Numerics;
using System;
using UnityEngine;

public class PacGuyCycle : MonoBehaviour
{
    private Transform PacGuy;
    private Vector3 TopRight;
    private Vector3 BottomRight;
    private Vector3 BottomLeft;
    private Vector3 TopLeft;
    private Vector3 CurrentPos;

    // private Transform[] transformArray;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position.Set(-11.5f,8.5f,0f);

        TopRight = new Vector3(-11.5f,12.5f,0f);

        BottomRight = new Vector3(-11.5f,8.5f,0f);

        BottomLeft = new Vector3(-16.5f,8.5f,0f);

        TopLeft = new Vector3(-16.5f,12.5f,0f);
    }

    // Update is called once per frame
    void Update()
    {
        CurrentPos = transform.position;

        Vector3.Lerp(CurrentPos,BottomRight,1/2);

        


        // if (CurrentPos = TopRight)
        // {
        //     Vector3.Lerp()
        // }
    }
}
