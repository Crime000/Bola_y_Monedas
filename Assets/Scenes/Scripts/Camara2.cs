using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Camara2 : MonoBehaviour
{
    public GameObject esfera;
    private Vector3 offsetCamara;
    private Vector3 rotar;

    public float offSetY, offSetZ;
    private float x, y;
    public float Suavizado;
    public float sensibilidad = 1f;

    public bool primeraPersona = false;
    
    

    private void Start()
    {
        transform.position = new Vector3(esfera.transform.position.x, esfera.transform.position.y + offSetY, esfera.transform.position.z - offSetZ);
        offsetCamara = transform.position - esfera.transform.position;
    }
    void Update()
    {

        if (Input.GetKeyUp("c") && primeraPersona == false)
        {
            primeraPersona = true;
        }
        else if (Input.GetKeyUp("c") && primeraPersona == true)
        {
            primeraPersona = false;
        }


        if (primeraPersona)
        {
            //camara primera persona.
            transform.position = esfera.transform.position;
            y = 5 * -Input.GetAxis("Mouse X");
            x = 5 * Input.GetAxis("Mouse Y");
            rotar = new Vector3(x * sensibilidad, y * sensibilidad, 0f);
            transform.eulerAngles = transform.eulerAngles - rotar;
        }
        else
        {
            //camara tercera persona
            
            transform.LookAt(esfera.transform.position);
            
            Quaternion giroCamara = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * sensibilidad, Vector3.up);
            offsetCamara = giroCamara * offsetCamara;
            Vector3 nuevaPosicion = esfera.transform.position + offsetCamara;

            transform.position = Vector3.Slerp(transform.position, nuevaPosicion, Suavizado);
            
        }
    }
}

