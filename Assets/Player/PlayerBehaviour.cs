using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public GameObject Game1;
    public GameObject Juego;
    


    private GameObject PickedObject;
    // Update is called once per frame
    void Update()
    {
        if (PickedObject != null)
        {
            if (Input.GetMouseButtonDown(0))
            {
                PickedObject.GetComponent<Rigidbody>().useGravity = true;
                PickedObject.GetComponent<Rigidbody>().isKinematic = false;
                //hago al objeto hijo de nada
                PickedObject.gameObject.transform.SetParent(null);
                PickedObject = null;
            }
        }


    }
    private void OnTriggerStay(Collider col)
    {
        if (col.gameObject.CompareTag("Game1"))
        {
            if (Input.GetMouseButtonDown(1) && PickedObject == null)
            {
                //Al agarrar el objeto se desactiva la graverdad
                col.GetComponent<Rigidbody>().useGravity = false;

                //Al agarrar el objeto kinematic se activa
                col.GetComponent<Rigidbody>().isKinematic = true;

                //Mueve el objeto al empty Hand
                col.transform.position = Game1.transform.position;

                //Convierte al objeto hijo del player
                col.gameObject.transform.SetParent(Game1.gameObject.transform);


                Juego.transform.localEulerAngles = new Vector3(0, 0, 90);

                PickedObject = col.gameObject;


            }
        }
    }
}
