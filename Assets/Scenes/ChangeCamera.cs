using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public GameObject Player;
    public GameObject Desactivate;
    public GameObject Comprobante;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Comprobante.transform.position.y == 10)
        {
            Player.SetActive(true);

            Desactivate.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Cube")
        {
            Player.SetActive(false);

            Desactivate.SetActive(true);
        }
        
    }
}
