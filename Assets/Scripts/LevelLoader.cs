using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[CreateAssetMenu(menuName ="Managers/LevelLoader")]
public class LevelLoader : ScriptableObject
{
    public void Reload()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(0);
    }

    public void LoadLevel(string s)
    {
        SceneManager.LoadScene(s);
    }

    public void LoadNext()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
