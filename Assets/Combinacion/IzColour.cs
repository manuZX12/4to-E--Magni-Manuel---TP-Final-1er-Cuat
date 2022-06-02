using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IzColour : MonoBehaviour
{
    public int Comprobante = 4;
    public Color Green;
    public Color Grey;
    public Renderer Render;
    public GameObject Cylinder;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Cylinder.transform.localEulerAngles.x == 0)
        {



            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Comprobante = Comprobante + 1;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Comprobante = Comprobante - 1;
            }
            if (Comprobante == 3)
            {
                Render = GetComponent<Renderer>();
                Render.material.color = Green;
            }
            else
            {
                Render = GetComponent<Renderer>();
                Render.material.color = Grey;
            }

            if (Comprobante > 5)
            {
                Comprobante = 5;
            }
            if (Comprobante < 3)
            {
                Comprobante = 3;
            }

        }
        else
        {
            Render = GetComponent<Renderer>();
            Render.material.color = Grey;
        }
    }
}


