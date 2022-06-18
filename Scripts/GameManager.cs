using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour

{
    public GameObject GameOverImage;
    public GameObject gameOverCanvas;
    public GameObject ReplaySceneCanvas;
    private void Start()
    {
        gameOverCanvas.SetActive(false);
        GameOverImage.SetActive(false);
        ReplaySceneCanvas.SetActive(false);
        Time.timeScale = 1;   
    }
    public void GameOver()
    {
        GameOverImage.SetActive(true);
        gameOverCanvas.SetActive(true);
        ReplaySceneCanvas.SetActive(true);
        Time.timeScale = 0;
    }
    public void Replay()
    {
        SceneManager.LoadScene(0);

    }
}
