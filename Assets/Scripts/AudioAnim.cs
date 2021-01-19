using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioAnim : MonoBehaviour
{


    public void playAudio()
    {
        GetComponent<AudioSource>()?.Play();
        Debug.Log("Audio");
    }
}
