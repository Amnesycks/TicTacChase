using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void QuitApplication()
    {
        Debug.Log("Game exited");
        Application.Quit();
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("InfiniteLevel");
    }

    public void RetryLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    public void StartGame()
    {
        SceneManager.LoadScene("TutoLevel");
    }
}