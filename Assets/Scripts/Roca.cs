using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roca : MonoBehaviour
{

    public float movX, movZ;
    Rigidbody fisicas;
    public float velocidad;
    public ParticleSystem escombros;

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
    }

    private void FixedUpdate()
    {
        Vector3 rodar = new Vector3(movX * velocidad, fisicas.velocity.y, movZ * velocidad);
        fisicas.velocity = rodar;
        
        if(movX != 0.0 || movZ != 0)
        {
            escombros.transform.position = transform.position;
            escombros.Play();
        }
    }
}
