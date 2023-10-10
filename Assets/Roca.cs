using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roca : MonoBehaviour
{

    public float movX, movZ;
    Rigidbody fisicas;
    public float aceleracion1;
    public float aceleracion2;

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
        Vector3 rodar = new Vector3(movX * 5, fisicas.velocity.y, movZ * 5);
        fisicas.velocity = rodar;

        if (movX > 0 || movX < 0)
        {
            fisicas.velocity = rodar * aceleracion1;
        }
    }
}
