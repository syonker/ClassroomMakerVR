﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCursor : MonoBehaviour
{

    public GameObject cam;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //transform.position = cam.transform.position + cam.transform.forward * 8;
        transform.position = cam.transform.position;

        transform.rotation = cam.transform.rotation;

    }
}