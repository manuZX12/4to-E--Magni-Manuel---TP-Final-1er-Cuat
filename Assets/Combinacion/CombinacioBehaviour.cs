using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombinacioBehaviour : MonoBehaviour
{
    public GameObject NumeroMID;
    public GameObject NumeroIZ;
    public GameObject NumeroDR;
    private int bloqueo = 0;
    private int grados = 0;
    private string flecha = "";
    public int Comprobante = 4;

    // Start is called before the first frame update
    void Start()
    {
        Comprobante = 4;
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.localEulerAngles.x == 0)
        {

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Comprobante = Comprobante + 1;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Comprobante = Comprobante - 1;
            }

            if (Comprobante == 4)
            {


                if (bloqueo == 0)
                {
                    if (Input.GetKey(KeyCode.DownArrow))
                    {
                        bloqueo = 1;
                        flecha = "l";
                    }
                    if (Input.GetKey(KeyCode.UpArrow))
                    {
                        bloqueo = 1;
                        flecha = "r";
                    }

                }
                else
                {
                    if (grados < 90)
                    {
                        grados += 1;
                        if (flecha.Equals("l"))
                        {
                            this.NumeroMID.GetComponent<Transform>().transform.Rotate(0, 1, 0, Space.Self);
                        }
                        if (flecha.Equals("r"))
                        {
                            this.NumeroMID.GetComponent<Transform>().transform.Rotate(0, -1, 0, Space.Self);
                        }


                    }
                    else
                    {
                        bloqueo = 0;
                        grados = 0;

                    }
                    if (NumeroMID.transform.localEulerAngles.y == -90)
                    {
                        Comprobante=1;
                    }
                }
            }


            if (Comprobante == 5)
            {
                if (bloqueo == 0)
                {
                    if (Input.GetKey(KeyCode.DownArrow))
                    {
                        bloqueo = 1;
                        flecha = "l";
                    }
                    if (Input.GetKey(KeyCode.UpArrow))
                    {
                        bloqueo = 1;
                        flecha = "r";
                    }

                }
                else
                {
                    if (grados < 90)
                    {
                        grados += 1;
                        if (flecha.Equals("l"))
                        {
                            this.NumeroDR.GetComponent<Transform>().transform.Rotate(0, 1, 0, Space.Self);
                        }
                        if (flecha.Equals("r"))
                        {
                            this.NumeroDR.GetComponent<Transform>().transform.Rotate(0, -1, 0, Space.Self);
                        }


                    }
                    else
                    {
                        bloqueo = 0;
                        grados = 0;

                    }
                }
                if (NumeroDR.transform.localEulerAngles.y == 180)
                {
                    Comprobante = 2;
                }
            }



            if (Comprobante == 3)
            {
                if (bloqueo == 0)
                {
                    if (Input.GetKey(KeyCode.DownArrow))
                    {
                        bloqueo = 1;
                        flecha = "l";
                    }
                    if (Input.GetKey(KeyCode.UpArrow))
                    {
                        bloqueo = 1;
                        flecha = "r";
                    }

                }
                else
                {
                    if (grados < 90)
                    {
                        grados += 1;
                        if (flecha.Equals("l"))
                        {
                            this.NumeroIZ.GetComponent<Transform>().transform.Rotate(0, 1, 0, Space.Self);
                        }
                        if (flecha.Equals("r"))
                        {
                            this.NumeroIZ.GetComponent<Transform>().transform.Rotate(0, -1, 0, Space.Self);
                        }


                    }
                    else
                    {
                        bloqueo = 0;
                        grados = 0;

                    }
                }
                if (NumeroMID.transform.localEulerAngles.y == -90)
                {
                    Comprobante = 1;
                }
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
    }

}
