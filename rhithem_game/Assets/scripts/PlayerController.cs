using System;
using System.Threading;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject up;
    public GameObject down;
    public GameObject left;
    public GameObject right;
    void Start()
    {
        up.SetActive(false);
        down.SetActive(false);
        left.SetActive(false);
        right.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Console.WriteLine("up is pressed");
            up.SetActive(true);
            Thread.Sleep(500);
            up.SetActive(false);
        }
    }
}
