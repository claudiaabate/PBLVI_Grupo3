using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class OneChild : MonoBehaviour
{
    public int maxChildAmount = 1;
    public Transform Top;

    void Update()
    {
        if (transform.childCount > maxChildAmount)
        {
            for (int i = maxChildAmount; i < transform.childCount; i++)
            {
                transform.GetChild(i).SetParent(Top);
            }
        }
    }
}
