using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIManager : MonoBehaviour
{
    public GameObject Menu;


    // Start is called before the first frame update
    void Start()
    {
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

    public void Salir()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

}
