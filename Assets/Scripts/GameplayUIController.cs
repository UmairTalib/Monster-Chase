using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayUIController : MonoBehaviour
{

    public void RestartGame()
    {
        SceneManager.LoadScene(Utils.GAMEPLAY_SCENE);
    }

    public void HomeButton()
    {
        SceneManager.LoadScene(Utils.MENU_SCENE);
    }

}