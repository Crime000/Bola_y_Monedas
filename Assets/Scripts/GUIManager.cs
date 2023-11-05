using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{
    public GameObject Menu;
    public GameObject OpcionesMenu;
    public GameObject derrota;

    // Start is called before the first frame update
    void Start()
    {
        derrota.SetActive(false);
        OpcionesMenu.SetActive(false);
        Menu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Update()
    {
        if (Input.GetKey("escape"))
        {
            Menu.SetActive(true);
            Time.timeScale = 0;
            
        }
    }
    public void Jugar()
    {
        //LeanTween.scale(Menu, Vector3.zero, 1).setEase(LeanTweenType.easeInQuad);
        Time.timeScale = 1;
        Menu.SetActive(false);
    }

    public void Opciones()
    {
        Menu.SetActive(false);
        OpcionesMenu.SetActive(true);
    }

    public void Volver()
    {
        OpcionesMenu.SetActive(false);
        Menu.SetActive(true);
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        derrota.SetActive(false);
    }

    public void Salir()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

}
