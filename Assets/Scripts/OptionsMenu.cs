using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public Button male;
    public Button female;
    public bool isFemaleSelected = false;

    public AudioMixer audioMixer;

    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("Volume", volume);
    }

    public void MaleSwitch()
    {
      isFemaleSelected = false;
          
    }
    public void FemaleSwitch()
    {
        isFemaleSelected = true;
    }




}
