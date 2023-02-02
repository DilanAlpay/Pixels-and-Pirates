using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSound : MonoBehaviour
{
    public AudioManager aud;
    public List<AudioClip> clips;

    public void PlayRandomSound()
    {
        int choice = Random.Range(0, clips.Count);
        aud.Play(clips[choice]);
    }
}
