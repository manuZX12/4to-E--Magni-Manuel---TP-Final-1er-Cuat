using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandBehaviour : MonoBehaviour
{
    public GameObject hand;
    private GameObject PickedObject;
    // Update is called once per frame
    void Update()
    {
        if (PickedObject != null)
        {
            if (Input.GetMouseButtonUp(1))
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
        if (col.gameObject.CompareTag("PickedObject"))
        {
            if (Input.GetMouseButtonDown(1) && PickedObject == null)
            {
                //Al agarrar el objeto se desactiva la graverdad
                col.GetComponent<Rigidbody>().useGravity = false;

                //Al agarrar el objeto kinematic se activa
                col.GetComponent<Rigidbody>().isKinematic = true;

                //Mueve el objeto al empty Hand
                col.transform.position = hand.transform.position;

                //Convierte al objeto hijo del player
                col.gameObject.transform.SetParent(hand.gameObject.transform);

                PickedObject = col.gameObject;


            }
        }
    }
    //private void OnGUI()
   // {
        //Rect rect = new Rect(Screen.width / 2, Screen.height / 2, puntero.width, puntero.height);
       //GUI.DrawTexture(rect, puntero);
    //}
}