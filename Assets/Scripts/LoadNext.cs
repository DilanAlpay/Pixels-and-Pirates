﻿using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadNext : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
