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

    public Sprite restartButtonIdle;
    public Sprite restartButtonHover;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        isEndGame = false;
        panelEndGame.SetActive(false);
        isTheFirstStart = true;
    }

    // Update is called once per frame
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

    public void RestartButtonIdle()
    {
        restartButton.GetComponent<Image>().sprite = restartButtonIdle;
    }

    public void RestartButtonHover()
    {
        restartButton.GetComponent<Image>().sprite = restartButtonHover;
    }

    public void RestartButtonExit()
    {
        restartButton.GetComponent<Image>().sprite = restartButtonIdle;
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
}

    