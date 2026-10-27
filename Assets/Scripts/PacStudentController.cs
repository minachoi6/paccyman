using System;
using System.Xml.Serialization;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.Assemblies;
using UnityEngine.Tilemaps;

public class PacStudentController: MonoBehaviour
{
    private int rows = 28;
    private int cols = 28;
    public int[,] levelMap;
    private GameObject origin;
    private Vector3 o;
    private LevelGrid lvlGrid;

    private float t;
    private Vector3 movement;
    private string lastInput;
    private bool islerping;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        islerping = false;
        //get tilegrid, align the array to the grid
        // origin = GetComponent<Transform>().position;

        o = origin.GetComponent<Transform>().position;

        for (int i = 0;i < rows;i ++) {
            for (int j = 0;j < cols;j++) {


                // lvlGrid.levelMap[i,j] = 
            }
        }


        t = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            movement = Vector3.up;
            lastInput = "w";
        }
        if (Input.GetKeyDown("a"))
        {
            movement = Vector3.left;
            lastInput = "a";
        }
        if (Input.GetKeyDown("s"))
        {
            movement = Vector3.down;
            lastInput = "s";
        }
        if (Input.GetKeyDown("d"))
        {
            movement = Vector3.right;
            lastInput = "d";
        }
        lerper(transform,transform.position,transform.position + movement,Time.deltaTime, 1.5f);
    }

    void lerper(Transform target, Vector3 currentPos, Vector3 nextPos,float startTime,float duration)
    {
        //if tiles are 5 or 6 man idk

        islerping = true;

        if (Vector3.Distance(target.position, nextPos) > 0.1f){
            float timePassed = Time.time - startTime;
            float t = timePassed / duration;

            target.position = Vector3.Lerp(currentPos,nextPos,t);

        } else {
            target.position = nextPos;
            islerping = false;
        }
    }





}
