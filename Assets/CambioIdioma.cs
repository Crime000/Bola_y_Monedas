using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class CambioIdioma : MonoBehaviour
{
    public bool activo = false;
    public int IDactual;
    public GameObject espa�ol;
    public GameObject ingles;
    public GameObject tsonga;

    public int ID;

    void Start()
    {
        if (ID == 0)                    // Cambiar Imagen de Idioma--------------
        {
            tsonga.SetActive(false);
            ingles.SetActive(true);
            espa�ol.SetActive(false);
        }
        else if (ID == 1)
        {
            tsonga.SetActive(false);
            ingles.SetActive(false);
            espa�ol.SetActive(true);
        }
        else if (ID == 2)
        {
            tsonga.SetActive(true);
            ingles.SetActive(false);
            espa�ol.SetActive(false);
        }
    }

    IEnumerator SetLocale(int IDLocale)      // Instanciar Idioma---------------------
    {
        activo = true;
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[IDLocale];
        activo = false;

        if (IDLocale == 0)                    // Cambiar Imagen de Idioma--------------
        {
            tsonga.SetActive(false);
            ingles.SetActive(true);
            espa�ol.SetActive(false);
        }
        else if (IDLocale == 1)
        {
            tsonga.SetActive(false);
            ingles.SetActive(false);
            espa�ol.SetActive(true);
        }
        else if (IDLocale == 2)
        {
            tsonga.SetActive(true);
            ingles.SetActive(false);
            espa�ol.SetActive(false);
        }
    }

    public void Ingles()                  // Bot�n derecho---------------------------
    {
        IDactual += 1;

        if (activo == true && IDactual < 2)
        {
            Debug.Log(IDactual);
            return;
        }
        else if (IDactual > 2)
        {
            IDactual = 0;
        }
        StartCoroutine(SetLocale(IDactual));

    }
}
