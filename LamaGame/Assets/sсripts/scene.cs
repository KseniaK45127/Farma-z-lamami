using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene : MonoBehaviour
{
    public void Scenes(int numberscenes)
    {
        SceneManager.LoadScene(numberscenes);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
