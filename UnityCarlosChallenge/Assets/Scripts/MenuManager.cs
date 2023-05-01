using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    [SerializeField] private GameObject initialMenu;
    [SerializeField] private GameObject settignsMenu;

    

    public void SquareLevelLoad()
    {
        SceneManager.LoadScene("SquareLevel");
    }

    public void HexagonLevelLoad()
    {
        SceneManager.LoadScene("HexagonLevel");
    }

    public void OpenSettings()
    {
        initialMenu.SetActive(false);
        settignsMenu.SetActive(true);
    }

    public void CloseSettings()
    {
        settignsMenu.SetActive(false);
        initialMenu.SetActive(true);
    }

    public void QuitGame()
    {
        Debug.Log("Quit the game");
        Application.Quit();
    }
}
