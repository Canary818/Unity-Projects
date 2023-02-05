/**
 * Ardity (Serial Communication for Arduino + Unity)
 * Author: Daniel Wilches <dwilches@gmail.com>
 * Modifications for InterfaceLab 2020 to move a cube
 *
 * This work is released under the Creative Commons Attributions license.
 * https://creativecommons.org/licenses/by/2.0/
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MyListener : MonoBehaviour
{
    GameObject cubeModifier;
    
    void Start() // Start is called before the first frame update
    {
        cubeModifier = GameObject.Find("Cube");
    }
void Update() // Update is called once per frame
    {
    }
void OnMessageArrived(string msg)
    {
        // Debug.Log("moving at speed: " + msg);
        float speed = float.Parse(msg) * 10;
        cubeModifier.gameObject.transform.Translate(Vector3.right * Time.deltaTime * speed);
    }
    // Invoked when a connect/disconnect event occurs. The parameter 'success'
    // will be 'true' upon connection, and 'false' upon disconnection or
    // failure to connect.
    void OnConnectionEvent(bool success)
    {
        Debug.Log(success ? "Device connected" : "Device disconnected");
    }
}