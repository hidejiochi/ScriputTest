using UnityEngine;
using System.Collections;

public class Task01 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

        int[] a = new int[5];

        a[0] = 10;
        a[1] = 20;
        a[2] = 30;
        a[3] = 40;
        a[4] = 50;

        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(a[i]);
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
