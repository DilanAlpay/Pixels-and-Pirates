using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioSetter : MonoBehaviour
{
    public AudioManager manager;
    // Start is called before the first frame update
    void Awake()
    {
        manager.source = GetComponent<AudioSource>();
    }
    
}
