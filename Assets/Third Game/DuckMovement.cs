using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckMovement : MonoBehaviour
{

    public float movementSpeed;
    public float JumpSpeed;
    public GameObject FinishLine;
    public GameObject Comprobante;
    private Vector3 move = Vector3.zero;
    public GameObject Camera2;
    public GameObject CamerPLayer;
    void Start()
    {
    }

    void Update()
    {
       
        if (transform.position.y > 2)
        {
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(0, 0, -movementSpeed);
            }
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(0, 0, movementSpeed);
            }
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(0, JumpSpeed, 0);
            }
            else
            {
                transform.Translate(0, -JumpSpeed, 0);
            }

        }


    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Water")
        {
            transform.position = new Vector3(7.6f, 3.929f, 2.293f);
            //SceneManager.LoadScene("Scene"); carga la sig escena , se podría usar al final.


        }
        if (col.gameObject.name == "Finish")
        {
            Camera2.SetActive(false);
            CamerPLayer.SetActive(true);
            Destroy(FinishLine);
            GetComponent<Rigidbody>().useGravity = true;
            GetComponent<Rigidbody>().isKinematic = false;

        }
        if(col.gameObject.tag == "Cube1")
        {
            if (Input.GetMouseButtonDown(1))
            {
                Camera2.SetActive(true);
                CamerPLayer.SetActive(false);
            }
        }

        
    }
}
