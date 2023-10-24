using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muros : MonoBehaviour
{
    public ParticleSystem fragmentos;
    public int Puntos;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Roca"))
        {
            PuntosPorCofre(Puntos);
            fragmentos.transform.position = transform.position;
            fragmentos.Play();
            Destroy(gameObject);
        }
    }

    public void PuntosPorCofre(int PuntosObtenidos)
    { 
        PuntosObtenidos = Puntos;
    }
}
