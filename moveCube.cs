using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCube : MonoBehaviour
{
   
    public bool isFiring;
    public Transform spawnLocation;

    public float timeBetweenShots;
    private float shotCounter;

    [SerializeField]
    private GameObject bullet;
    public GameObject cube;
    public Joystick joystick;
    public Joystick joystick2;
    private Rigidbody rb;
    private float zAxis;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 lookvector = new Vector3(joystick2.Horizontal, joystick2.Vertical, 0f);
        transform.LookAt(transform.position + lookvector);

        float a = joystick2.Horizontal;
        float b = joystick2.Vertical;

        if (a != 0 && b != 0)
        {
            shoot();
        }
        


        float hor = joystick.Horizontal * 5;

        float ver = joystick.Vertical * 5;

        Vector3 vel = rb.velocity;

        vel.x = hor;
        vel.y = ver;

        rb.velocity = vel;

        
    }


    void shoot()
    {
        shotCounter -= Time.deltaTime;
        if(shotCounter <= 0)
        {
            shotCounter = timeBetweenShots;
            Instantiate(bullet, spawnLocation.position, spawnLocation.rotation);
        }
    }
}






// here are a bunch of random codes I tried that didn't do what I wanted

/*       float a = joystick2.Horizontal;
         float b = joystick2.Vertical;

         if(a !=0 && b != 0)
         {
             cube.transform.Rotate(0f, a*5, 0f);
             shoot();
         }*/

/*Vector3 playerDirection = Vector3.right * joystick2.Horizontal + Vector3.forward * joystick2.Vertical;
        if (playerDirection.sqrMagnitude > 0.0f)
{
    transform.rotation = Quaternion.LookRotation(playerDirection, Vector3.forward);
    shoot();
}*/

/* Vector3 direction = joystick2.Direction;

    cube.transform.rotation = Quaternion.Euler(direction);*/

//transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime, 0f, Input.GetAxis("Vertical") * Time.deltaTime);