using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ControlVolumen : MonoBehaviour
{
    public Slider slider;
    public float valorSlider;
    public TextMeshProUGUI mute;

    // Start is called before the first frame update
    void Start()
    {

        slider.value = PlayerPrefs.GetFloat("volumenAudio", 0.5f);
        AudioListener.volume = slider.value;
        RevisarMute();

    }

    public void CambiarSlider(float valor)
    {
        valorSlider = valor;
        PlayerPrefs.SetFloat("volumenAudio", valorSlider);
        AudioListener.volume = slider.value;
        RevisarMute();
    }

    public void RevisarMute()
    {
        if( valorSlider == 0)
        {
            mute.enabled = true;
        }
        else
        {
            mute.enabled = false;
        }
    }
}
