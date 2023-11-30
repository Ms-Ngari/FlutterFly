using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuPlayGame : MonoBehaviour
{
    public GameObject stopScreen;
    public GameObject liveCoins;
    public GameObject liveDis;
    public GameObject thePlayer;
    public GameObject levelControl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void Pause()
    {        
            Time.timeScale = 0;
        
    }
    public void Resume()
    {
        Time.timeScale = 1;

    }
    public void Stop()
    {
        thePlayer.GetComponent<PlayerMovement>().enabled = false;
        levelControl.GetComponent<LevelDistance>().enabled = false;
        liveCoins.SetActive(false);
        liveDis.SetActive(false);
        stopScreen.SetActive(true);
    }
}
