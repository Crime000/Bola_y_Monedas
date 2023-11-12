using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CambioIdioma : MonoBehaviour
{
    public bool activo = false;
    public int IDactual;
    public GameObject español;
    public GameObject ingles;
    public GameObject tsonga;

    IEnumerator SetLocale(int IDLocale)      // Instanciar Idioma---------------------
    {
        activo = true;
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[IDLocale];
        Debug.Log(IDLocale);
        activo = false;
    }

    public void Ingles()                  // Botón derecho---------------------------
    {
        IDactual = 0;

        if(activo == true && IDactual == 0)
        {
            return;
        }
        
        StartCoroutine(SetLocale(IDactual));
    }

    public void Espanol()                  // Botón derecho---------------------------
    {
        IDactual = 2;

        if (activo == true && IDactual == 2)
        {
            return;
        }

        StartCoroutine(SetLocale(IDactual));
    }

    public void Tsonga()                  // Botón derecho---------------------------
    {
        IDactual = 3;

        if (activo == true && IDactual == 3)
        {
            return;
        }

        StartCoroutine(SetLocale(IDactual));
    }
}
