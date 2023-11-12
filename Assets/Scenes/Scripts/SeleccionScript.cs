using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Localization.Settings;
using TMPro;

public class SeleccionScript : MonoBehaviour
{
    public bool activo = false;
    public int IDactual = 1;
    public GameObject espa�ol;
    public GameObject ingles;
    public GameObject tsonga;

    public void Start()
    {
        tsonga.SetActive(false);
        ingles.SetActive(false);
        espa�ol.SetActive(true);
    }
    IEnumerator SetLocale(int IDLocale)      // Instanciar Idioma---------------------
    {
        activo = true;
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[IDLocale];
        activo = false;

        if(IDLocale == 0)                    // Cambiar Imagen de Idioma--------------
        {
            tsonga.SetActive(false);
            ingles.SetActive(true);
            espa�ol.SetActive(false);
        }
        else if(IDLocale == 2)
        {
            tsonga.SetActive(false);
            ingles.SetActive(false);
            espa�ol.SetActive(true);
        }
        else if (IDLocale == 3)
        {
            tsonga.SetActive(true);
            ingles.SetActive(false);
            espa�ol.SetActive(false);
        }
    }
    
    public void Aceptar()                  // Aceptar Idioma--------------------------
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

    public void Derecha()                  // Bot�n derecho---------------------------
    {
        IDactual += 1;

        if(activo == true && IDactual < 3)
        {
            return;
        }
        else if(IDactual == 1)
        {
            IDactual = 2;
        }
        else if(IDactual > 3)
        {
            IDactual = 0;
        }
        StartCoroutine(SetLocale(IDactual));
        
    }

    public void Izquierda()                //Bot�n Izquierdo-------------------------
    {
        IDactual -= 1;

        if (activo == true && IDactual > 0)
        {
            return;
        }
        else if (IDactual == 1)
        {
            IDactual = 0;
        }
        else if (IDactual < 0)
        {
            IDactual = 3;
        }
        StartCoroutine(SetLocale(IDactual));
    }
}
