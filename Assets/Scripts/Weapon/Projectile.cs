using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Rigidbody rb;
    public PlayerControls player;

    public float speed = 7;
    public int damage = 25;


    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody>();
        player = FindObjectOfType<PlayerControls>();


        transform.rotation = player.transform.rotation;

        rb.velocity = transform.forward * speed;
        //rb.velocity = new Vector3(speed, 0 , 0);

   

        Destroy(gameObject, 1f); // destroy the bullet after 1 second
    }



    // Update is called once per frame
    void Update()
    {
    }

    //collision detection - On enter
    private void OnTriggerEnter(Collider hitInfo)
    {
        Debug.Log(hitInfo.name);        // logs the type of object this bullet hits

        

        Destroy(gameObject);    // destroys the bullet 
    }


}
