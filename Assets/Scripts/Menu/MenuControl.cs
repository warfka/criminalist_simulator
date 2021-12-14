using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuControl : MonoBehaviour
{
    public void StartPressed()
    {
        SceneManager.LoadScene("Game");
    }

    public void DocumentationPressed() //дндекюрэ
    {
        Application.Quit();
    }

    public void ExitPressed()
    {
        Application.Quit();
    }
}
