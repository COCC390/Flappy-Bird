using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartUI : MonoBehaviour
{
    public void OnClickPlayBtn() => SceneManager.LoadScene(0);

    public void OnClickExitBtn() => Application.Quit();
        
}
