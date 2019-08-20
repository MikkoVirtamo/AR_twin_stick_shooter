using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour
{
    private float bulletLife;
    private float bulletDeath;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        bulletLife = 0;
        bulletDeath = 50;
    }

    // Update is called once per frame
    void Update()
    {
        bulletLife += .2f;
        if(bulletLife >= bulletDeath)
        {
            Destroy(this.gameObject);
        }
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
