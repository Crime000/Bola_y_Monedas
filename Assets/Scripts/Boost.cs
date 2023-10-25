using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
    public Roca roca;
    public float tiempo = 5;

    private void FixedUpdate()
    {
        if (roca.velocidad == 15)
        {
            tiempo -= Time.fixedDeltaTime;

            if (tiempo >= 0)
            {
                roca.velocidad = 5;
                Destroy(gameObject);
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Roca"))
        {
            roca.velocidad = 15;
        }
    }
}
