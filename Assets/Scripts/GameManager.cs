using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int PuntosTotales { get { return Puntos; } }

    public int Puntos;
    public float tiempo;

    public void Update()
    {
        tiempo += Time.deltaTime;
        TiempoTranscurrido();
    }

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
        if(Puntos == 4)
        {
            Debug.Log( "Has ganado, tiempo total: " + tiempo + " segundos");
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }

    public void PuntosPorCofre(int PuntosObtenidos)
    {
        Puntos += PuntosObtenidos;
    }
}
