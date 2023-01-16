using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuInGame : MonoBehaviour
{
    public GameObject gameMenu, pauseMenu, startMenu, finishMenu;
    private int i = 0;
    public Toplayici topla;
    public int score;
    public TextMeshProUGUI tmpro;
    // Start is called before the first frame update
    private void Awake()
    {
        Time.timeScale = 0;
        gameMenu.SetActive(false);
        pauseMenu.SetActive(false);
        finishMenu.SetActive(false);
        startMenu.SetActive(true);
        score = 0;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score = topla.height;
        tmpro.text = score.ToString();
    }
    public void StartButton()
    {
        Time.timeScale = 1;
        gameMenu.SetActive(true);
        startMenu.SetActive(false);
    }
    public void PauseButton()
    {
        Time.timeScale = 0;
        gameMenu.SetActive(false);
        pauseMenu.SetActive(true);
    }
    public void PlayButton()
    {
        Time.timeScale = 1;
        gameMenu.SetActive(true);
        pauseMenu.SetActive(false);
    }
    public void RestartButton()
    {
        SceneManager.LoadScene(i);
    }
    public void NextLevelButton()
    {
        SceneManager.LoadScene(i);
        finishMenu.SetActive(false);
    }

    public void FinishMenu()
    {
        Time.timeScale = 0;
        i++;
        finishMenu.SetActive(true);
        gameMenu.SetActive(false);
    }
}
