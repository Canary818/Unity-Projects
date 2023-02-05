using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class LEDClick : MonoBehaviour
{
    // Start is called before the first frame update
    SerialPort _serialPort = new SerialPort("COM13", 9600, Parity.None, 8, StopBits.One);  // create new serial port object as COM13
    int LEDState = 0;

    void Start()
    {
        _serialPort.Open();  
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetMouseButtonDown (0))
        {
            if(LEDState == 1)
            {
                _serialPort.Write("1");
                LEDState = 0;
            }
            else {
                _serialPort.Write("0");
                LEDState = 1;
            }
        }
    }

    void OnDestroy() 
    {
        _serialPort.Write("0");  // Turn off LED
        _serialPort.Close();     // Close port
    }

    
}

