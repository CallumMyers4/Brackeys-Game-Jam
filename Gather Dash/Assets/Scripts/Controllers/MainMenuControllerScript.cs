using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControllerScript : MonoBehaviour
{
    [SerializeField] GameObject OptionsPanel;
    [SerializeField] GameObject MainPanel;
    public void Play()
    {
        SceneManager.LoadScene("Central Base");
    }

    public void Options()
    {
        MainPanel.SetActive(false);
        OptionsPanel.SetActive(true);
    }

    public void Return()
    {
        OptionsPanel.SetActive(false);
        MainPanel.SetActive(true);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
