using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    float health = 10f;
    int score = 0;

    bool myBoolean = true;

    float thisIsADecimal = 3.14f;

    bool thisAThing = false;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(thisIsADecimal);
        thisIsADecimal++;
        Debug.Log(thisIsADecimal);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(0, 2, -10);

        Vector3 newPos = transform.position;


        if (Input.GetKey(KeyCode.D))
        {
            newPos.x++;
        }

        transform.position = newPos;

    }
}
