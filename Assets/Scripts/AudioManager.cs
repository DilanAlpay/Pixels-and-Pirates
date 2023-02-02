using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Managers/AudioManager")]
public class AudioManager : ScriptableObject
{
    public AudioSource source;

    public void Play(AudioClip c)
    {
        source.PlayOneShot(c);
    }
}
