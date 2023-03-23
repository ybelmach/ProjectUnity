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
            transform.Translate(transform.up * speed * Time.deltaTime);
        } 
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(transform.right * speed * Time.deltaTime * -1);
        } 
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(transform.up * speed * Time.deltaTime * -1);
        } 
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(transform.right * speed * Time.deltaTime);
        }
        
    }
}
