using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTowardsPlayer : MonoBehaviour
{
    [SerializeField]
    private Transform target;

    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(this.gameObject.transform.position);
        target = GameObject.FindGameObjectWithTag("Player").transform;
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameRunningScript.gameRunning == false)
        {
            Destroy(this.gameObject);
        }
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
