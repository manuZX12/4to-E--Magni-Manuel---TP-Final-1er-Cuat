using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsUIBehaviour : MonoBehaviour
{
    public GameObject ButtonYes;
    public GameObject ButtonNo;
    public GameObject FirstText;
    public GameObject ButtonExit;
    public GameObject ButtonReset;
    public GameObject SecondText;
    // Start is called before the first frame update
    void Start()
    {
        ButtonYes.SetActive(false);
        ButtonNo.SetActive(false);
        FirstText.SetActive(false);
        ButtonExit.SetActive(false);
        ButtonReset.SetActive(false);
        SecondText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void YesButton()
    {
        ButtonYes.SetActive(false);
        ButtonNo.SetActive(false);
        FirstText.SetActive(false);
        ButtonExit.SetActive(true);
        ButtonReset.SetActive(true);
        SecondText.SetActive(true);
    }
    public void NoButton()
    {
        float Position = Random.Range(-200, 200);
        float PositionY = Random.Range(-150, 150);
        ButtonNo.transform.Translate(Position, PositionY, 0);
    }
    public void ResetButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void ExitButton()
    {
        Application.Quit();
    }
}
