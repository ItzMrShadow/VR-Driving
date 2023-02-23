using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{

    public void Setup(int score)
    {
        gameObject.SetActive(true);

    }

    public void FindCity()
    {
        SceneManager.LoadScene("City01");
        Time.timeScale = 1f;
    }

    public void QuitButton()
    {
        Application.Quit();
    }


}
