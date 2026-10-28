using System;
using System.Data;
using System.Xml.Serialization;
using NUnit.Framework;
using Unity.Collections;
using UnityEditor.U2D.Aseprite;
using UnityEngine;
using UnityEngine.Assemblies;
using UnityEngine.Tilemaps;

public class PacStudentController: MonoBehaviour
{
    
    private int rows = 28;
    private int cols = 28;
    public int[,] array;
    private Array lvlGrid;
    private int cell;

    private float t;
    [SerializeField] private float speed = 5f;
    private Vector3 movement;
    private string lastInput;
    private bool islerping;
    private bool[,] isPellet;

    private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    isPellet = new bool[rows,cols];
        animator = gameObject.GetComponent<Animator>();
        islerping = false;

        for (int i = 0;i < rows;i ++) {
            for (int j = 0;j < cols;j++) {
                cell = lvlGrid.levelMap[i,j];

                if (cell == 5 || cell == 6) {
                    isPellet[rows,cols] = true;
                } 
                if (isPellet[i,j] == false)  {
                    t = 0f;
                    islerping = false;
                }
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
        lerper(transform,transform.position,transform.position + movement, 1.0f / speed);
    }

    void lerper(Transform target, Vector3 currentPos, Vector3 nextPos,float duration)
    {
        islerping = true;

        if (Vector3.Distance(target.position, nextPos) > 0.1f){

            float timePassed = Time.deltaTime;
            t = timePassed / duration;

            target.position = Vector3.Lerp(currentPos,nextPos,t);

        animator.SetFloat("Horizontal",nextPos.x - currentPos.x);
        animator.SetFloat("Vertical",nextPos.y - currentPos.y);

        } else {
            target.position = nextPos;
            islerping = false;
        }
    }
}

