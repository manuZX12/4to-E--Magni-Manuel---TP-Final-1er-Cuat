using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGame : MonoBehaviour
{
    public GameObject hand;
    private GameObject PickedObject;
    public GameObject Button, Botton, texto;
    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerStay(Collider col)
    {
        if (col.gameObject.CompareTag("FN"))
        {
            if (Input.GetMouseButtonDown(1) && PickedObject == null)
            {
                Button.SetActive(true);
                Botton.SetActive(true);
                texto.SetActive(true);
                Cursor.lockState = CursorLockMode.None;

            }
        }
    }
}
