﻿using UnityEngine;
using System.Collections;

public class Test2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // 
        int[] array = new int[5];

        // 
        array[0] = 1;
        array[1] = 2;
        array[2] = 3;
        array[3] = 4;
        array[4] = 5;

        // 配列の要素をすべて表示する
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
        for (int i = 4; 0 <=i; i--)
        {
            Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}