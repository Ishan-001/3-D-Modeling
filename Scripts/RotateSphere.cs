using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSphere : MonoBehaviour
{
    Vector3 movement;
    void Start()
    {
        movement=new Vector3(90,0,0);
    }
   
    void Update()
    {
        transform.Rotate(movement*Time.deltaTime);    
    }
}
