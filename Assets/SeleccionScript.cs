using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Localization.Settings;

public class SeleccionScript : MonoBehaviour
{
    public bool activo = false;
    private int IDactual = 0;

    IEnumerator SetLocale(int IDLocale)
    {
        activo = true;
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[IDLocale];
        activo = false;
    }
    
    public void Aceptar()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

    public void Derecha(int _ID)
    {
        if(activo == true && IDactual < 2)
        {
            _ID = IDactual;
            IDactual += 1;
            return;
            
        }
        StartCoroutine(SetLocale(_ID));
    }

    public void Izquierda(int _ID)
    {
        if (activo == true && IDactual > 0)
        {
            IDactual -= 1;
            _ID = IDactual;
            return;

        }
        StartCoroutine(SetLocale(_ID));
    }
}
