using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    public Light light;
    public InputActionReference action;
    void Start()
    {
        
        action.action.Enable();
        action.action.performed += (ctx) =>
    {
        if(light.color == Color.red){
            light.color = Color.white;
    }
        else{
        light.color = Color.red;
    }
    };
    }
}
