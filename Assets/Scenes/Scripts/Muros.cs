using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muros : MonoBehaviour
{
    public ParticleSystem fragmentos;
    public GameManager gameManager;
    public int Puntos;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Roca"))
        {
            gameManager.PuntosPorCofre(Puntos);
            fragmentos.transform.position = transform.position;
            fragmentos.Play();
            Destroy(gameObject);
        }
    }
}
