using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeleccionScript : MonoBehaviour
{
    public void Aceptar()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
}
