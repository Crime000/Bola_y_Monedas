using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Camara2 : MonoBehaviour
{
    public GameObject esfera;
    public float offSetY, offSetZ;
    public bool primeraPersona = false;
    private float y;
    public float sensibilidad = 1f;
    private Vector3 rotar;


    private void Start()
    {
        transform.position = new Vector3(esfera.transform.position.x, esfera.transform.position.y + offSetY, esfera.transform.position.z - offSetZ);
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
            rotar = new Vector3(0f, y * sensibilidad, 0f);
            transform.eulerAngles = transform.eulerAngles - rotar;
        }
        else
        {
            //camara tercera persona

            transform.position = new Vector3(esfera.transform.position.x, esfera.transform.position.y + offSetY, esfera.transform.position.z - offSetZ);
            y = 5 * -Input.GetAxis("Mouse X");
            rotar = new Vector3(0f, y * sensibilidad, 0f);
            transform.eulerAngles = transform.eulerAngles - rotar;
        }
    }
}

