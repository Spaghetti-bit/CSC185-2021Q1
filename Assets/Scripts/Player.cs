using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 2.0f;
    public Weapon[] weapons;

    private void Awake()
    {
        Debug.Log("Awoken!");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Initial Frame -- Start");
        
    }

    // Update is called once per frame
    void Update()
    {

        //Vector3 velocity = Vector3.zero;

        //velocity.x = Input.GetAxis("Horizontal");
        //velocity.z = Input.GetAxis("Vertical");

        //if (Input.GetButtonDown("Jump")) velocity.y = 40;



        ////GetComponent<Transform>().position = velocity; -- Equal to the code below.
        //transform.position += (velocity * speed) * Time.deltaTime;

        if(Input.GetButton("Fire1"))
        {
            Ray point = Camera.main.ScreenPointToRay(Input.mousePosition);
            weapons[0].fire(point.origin, point.direction);
        }


    }
}
