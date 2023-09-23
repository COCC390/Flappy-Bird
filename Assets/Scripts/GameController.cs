using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public bool isEndGame;
    bool isTheFirstStart;
    int gamePoint = 0;

    public GameObject panelEndGame;
    public Button restartButton;
    public Button endGameButton;
    public Text endPointText;
    public Text textPoint;

    void Start()
    {
        Time.timeScale = 0;
        isEndGame = false;
        panelEndGame.SetActive(false);
        isTheFirstStart = true;
    }

    void Update()
    {
        if (isEndGame)
        {
            if (Input.GetMouseButtonDown(0) && isTheFirstStart)
                StartGame();
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
                Time.timeScale = 1;
        }
    }

    public void GetPoint()
    {
        gamePoint++;
        textPoint.text = "Point: " + gamePoint.ToString();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(0);
    }
    public void RestartGame()
    {
        StartGame();
    }

    public void EndGame()
    {
        isEndGame = true;
        Time.timeScale = 0;
        panelEndGame.SetActive(true);
        endPointText.text = "Your point \n" + gamePoint.ToString();
        isTheFirstStart = false;
    }

    // onclick
    public void OnExitGame() => Application.Quit();

    public void OnReturnMenu() => SceneManager.LoadScene(1);
}

    