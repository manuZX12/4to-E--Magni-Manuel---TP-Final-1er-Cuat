using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionGam : MonoBehaviour
{
    public GameObject Game1;
    public GameObject Juego;
    private GameObject PickedObject;
    // Update is called once per frame
    void Update()
    {
        if (PickedObject != null)
        {
            if (Input.GetMouseButtonUp(1))
            {
                PickedObject.GetComponent<Rigidbody>().useGravity = true;
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

                //Mueve el objeto al empty Hand
                col.transform.position = Game1.transform.position;

                //Convierte al objeto hijo del player
                col.gameObject.transform.SetParent(Game1.gameObject.transform);

                Juego.transform.localEulerAngles = new Vector3(-89.079f, 0, 0);

                PickedObject = col.gameObject;


            }
        }
    }
}
