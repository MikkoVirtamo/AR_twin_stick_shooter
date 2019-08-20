using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameRunningScript : MonoBehaviour
{
    public static bool gameRunning;
    // Start is called before the first frame update
    void Start()
    {
        gameRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(gameRunning);
    }
}
