using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;


    private void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.up * speed * Time.deltaTime * 3);
        } 
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(transform.right * speed * Time.deltaTime * -1);
        } 
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(transform.right * speed * Time.deltaTime);
        }
        
    }
}
