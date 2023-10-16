using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara2 : MonoBehaviour
{

    public GameObject esfera;
    public float offSetY, offSetZ;
    public bool primeraPersona = false;

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
        }
        else
        {
            //camara tercera persona
            transform.position = new Vector3(esfera.transform.position.x, esfera.transform.position.y + offSetY, esfera.transform.position.z - offSetZ);
        }
    }
}
