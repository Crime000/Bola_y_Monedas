using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Camara2 : MonoBehaviour
{

    public GameObject esfera;
    public float offSetY, offSetZ;
    public bool primeraPersona = false;
    private float x, y;
    public float sensibilidad = 1f;
    private Vector3 rotar;

    void Update()
    {

        if (Input.GetKeyUp("c") && primeraPersona == false)
        {
            primeraPersona = true;
        }
        else if(Input.GetKeyUp("c") && primeraPersona == true)
        {
            primeraPersona = false;
        }


        if (primeraPersona)
        {
            //camara primera persona.
            transform.position = esfera.transform.position;
            y = 5 * -Input.GetAxis("Mouse X");
            x = 5 * Input.GetAxis("Mouse Y");
            rotar = new Vector3(x, y * sensibilidad, 0f);
            transform.eulerAngles = transform.eulerAngles - rotar;
        }
        else
        {
            //camara tercera persona
            transform.position = new Vector3(esfera.transform.position.x, esfera.transform.position.y + offSetY, esfera.transform.position.z - offSetZ);
            y = 5 * -Input.GetAxis("Mouse X");
            x = 5 * Input.GetAxis("Mouse Y");
            rotar = new Vector3(x, y * sensibilidad, 0f);
            transform.eulerAngles = transform.eulerAngles - rotar;
        }
    }
}
