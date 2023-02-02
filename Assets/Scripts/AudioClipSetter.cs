using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioClipSetter : MonoBehaviour
{
    private AudioSource source;
    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void Set(AudioClip clip)
    {
        source.clip = clip;
        source.Play();
    }
}
