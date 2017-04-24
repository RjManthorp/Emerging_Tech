using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using UnityEngine.UI;

public class input : MonoBehaviour
{
    SerialPort sp = new SerialPort("COM3", 9600);

    float x;
    float y = 0;
    float z;

    public float speed = 50;
    float readValue;
    public float sensitivity = 10;
    public Text inputValue;

    void Start()
    {
        sp.Open();
        sp.ReadTimeout = 1;
    }

    void Update()
    {
        if (sp.IsOpen)

            try
            {
                print(sp.ReadLine());
            }
            catch (System.Exception)
            {

            }
        readValue = float.Parse(sp.ReadLine());
        inputValue.text = readValue.ToString();
        transform.Translate(Vector3.up * Time.deltaTime * readValue /sensitivity);
        transform.Translate(Vector3.right * Time.deltaTime * speed);

    }

}