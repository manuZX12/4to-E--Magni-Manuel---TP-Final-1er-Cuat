using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMovement : MonoBehaviour
{
    private int bloqueo = 0;
    private float grados = 0;
    private string flecha = "";
    int comprobante;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.UpArrow))
        {
            comprobante++;
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            comprobante--;
        }

        
        if (bloqueo == 0)
            {
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    bloqueo = 1;
                    flecha = "l";
                }
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    bloqueo = 1;
                    flecha = "r";
                }

            }
            else
            {
                if (grados < 15)
                {
                    grados += 0.5f;
                    if (flecha.Equals("l"))
                    {
                        this.GetComponent<Transform>().transform.Rotate(1, 0, 0, Space.Self);
                    }
                    if (flecha.Equals("r"))
                    {
                        this.GetComponent<Transform>().transform.Rotate(-1, 0, 0, Space.Self);
                    }


                }
                else
                {
                    bloqueo = 0;
                    grados = 0;

                }
            }
        

    }
}
