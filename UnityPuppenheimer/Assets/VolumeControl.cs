using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    public Slider volumeSlider;

    void Start()
    {
        // Überprüfe, ob ein Slider zugewiesen ist
        if (volumeSlider == null)
        {
            Debug.LogError("VolumeSlider nicht zugewiesen! Weise ihn im Unity-Editor zu.");
            return;
        }

        // Setze die Lautstärke auf den aktuellen Slider-Wert
        AudioListener.volume = volumeSlider.value;

        // Hänge eine Funktion an das ValueChanged-Event des Sliders
        volumeSlider.onValueChanged.AddListener(ChangeVolume);
    }

    void ChangeVolume(float volume)
    {
        // Passe die Lautstärke entsprechend dem Slider-Wert an
        AudioListener.volume = volume;
    }
}
