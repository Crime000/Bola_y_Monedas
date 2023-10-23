using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roca : MonoBehaviour
{

    public float movX, movZ;
    Rigidbody fisicas;
    public float velocidad;
    public ParticleSystem escombros;
    private float gravedadTemporal;
    private float gravedad = 0;

    // Start is called before the first frame update
    void Start()
    {
        fisicas = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movX = Input.GetAxis("Horizontal");
        movZ = Input.GetAxis("Vertical");
        gravedad = transform.position.y;
    }

    private void FixedUpdate()
    {
        Vector3 rodar = new Vector3(movX * velocidad, fisicas.velocity.y, movZ * velocidad);
        fisicas.velocity = rodar;
        if(gravedad != 0)
        {
            gravedadTemporal = gravedadTemporal + gravedad;
        }
        else if(gravedad == 0)
        {
            gravedadTemporal = 0;
        }
    }
}
