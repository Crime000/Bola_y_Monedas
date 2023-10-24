using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int PuntosTotales { get { return Puntos; } }

    public int Puntos;
    public float tiempo;

    public Muros cofres;
    

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.Log("Mas de un Game Manager");
        }
    }

    public void TiempoTranscurrido()
    {
        tiempo = Time.deltaTime;
        if(Puntos == 5)
        {
            Debug.Log(tiempo + " segundos");
        }
    }

    public void SumarPuntos(int PuntosObtenidos)
    {
        Puntos += PuntosObtenidos;
        cofres.PuntosPorCofre(PuntosTotales);
    }
}
