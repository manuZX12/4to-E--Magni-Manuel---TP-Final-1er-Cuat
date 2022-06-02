using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DRColour : MonoBehaviour
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
                Comprobante++;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Comprobante--;
            }
            if (Comprobante == 5)
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
