using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Comeenzarbutton : MonoBehaviour
{
    public GameObject Blood;
    int I = -2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   
        
    }
    public void ButtonBehaviour()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
