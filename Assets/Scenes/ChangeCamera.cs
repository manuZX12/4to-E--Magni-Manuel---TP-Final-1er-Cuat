using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public GameObject Player;
    public GameObject Desactivate;
    int KK;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(KK == 1)
        {
            Player.SetActive(true);

            Desactivate.SetActive(false);
        }
            
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
            Player.SetActive(false);

            Desactivate.SetActive(true);
        
        
    }
}
