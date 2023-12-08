using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField]float moveSpeed = 10f;// unity da qo`shimcha page ochishga va boshqarishga yordam beradi 

    // Start is called before the first frame update
    void Start()

    {
        PrintInstructions();
    }

    // Update is called once per frame
    // once per frame means 24 times per second 

    void Update()  // in update everything is continues like a circle 

    {
       MovePlayer ();
    }

    void PrintInstructions ()
    {
        Debug.Log("Welcome to my first game");
        Debug.Log(" There is going to be some awesome levels that you like");
        Debug.Log("try to enjoy every moment");     // the Debag.Log helps to make some comments and the appear during the game
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime * moveSpeed; 
        float zValue = Input.GetAxis("Vertical")*Time.deltaTime * moveSpeed;   // this is the place where i going is controlled s
        transform.Translate(xValue,0,zValue);

    }
}
