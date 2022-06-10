using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
  
    public GameObject Canvas;
    public GameObject Player;
    public GameObject CameraMain;
    void Start()
    {
        Canvas.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) )
        {
            Player.SetActive(false);
            CameraMain.SetActive(true);
            Canvas.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }

    }
    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void BackToScene()
    {
        Canvas.SetActive(false);
        CameraMain.SetActive(false);
        Player.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}