using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartButton : MonoBehaviour
{
  
    public GameObject Button1,Button2,Button3,GameOver, contador;
    public GameObject Player;
    public GameObject CameraMain;

    public int min, seg;
    public Text timepo;
    private float restante;
    private bool enMarcha;

    public AudioClip win;
    public AudioSource source;
    void Start()
    {
        Button1.SetActive(false);
        Button3.SetActive(false);
        Button2.SetActive(false);
        GameOver.SetActive(false);
        restante = (min * 60) + seg;
        enMarcha = true;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) )
        {
            Player.SetActive(false);
            CameraMain.SetActive(true);
            Button1.SetActive(true);
            Button3.SetActive(true);
            Button2.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }


        if (enMarcha)
        {
            restante -= Time.deltaTime;
            if (restante < 1)
            {
                enMarcha = false;
                GameOver.SetActive(true);
                Button1.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                contador.SetActive(false);
                source.clip = win;
                source.Play();
            }
            int tempMin = Mathf.FloorToInt(restante / 60);
            int tempSeg = Mathf.FloorToInt(restante % 60);
            timepo.text = string.Format("{00:00}:{01:00}", tempMin, tempSeg);
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            enMarcha = false;
        }

    }
    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void BackToScene()
    {
        Button1.SetActive(false);
        Button3.SetActive(false);
        Button2.SetActive(false);
        CameraMain.SetActive(false);
        Player.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        enMarcha = true;

    }
    public void ExitGame()
    {
        Application.Quit();
    }
}