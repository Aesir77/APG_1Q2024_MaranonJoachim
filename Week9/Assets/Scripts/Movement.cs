using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float x_speed, nx_speed, timer;
    public Rigidbody2D rb;
   
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(x_speed, 0);
           

        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(nx_speed, 0);


        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(0, 0);

        }
        
       
    }
}

