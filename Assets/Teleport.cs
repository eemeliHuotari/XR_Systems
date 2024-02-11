using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Teleport : MonoBehaviour
{

    public InputActionReference action;
    void Start()
    {
        Vector3 position = transform.position;
        action.action.Enable();
        action.action.performed += (ctx) =>
    {
        if(position == new Vector3(20,30,0)){
            transform.position = new Vector3(5,1,0);
            position = transform.position;
    }    
        else{
         transform.position = new Vector3(20, 30, 0);
        position = transform.position;
    }
    };
    }
}
