using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerOn : MonoBehaviour
{
    public GameObject hand;
    private GameObject PickedObject;
    public GameObject Camera;
    public GameObject CamerPLayer;
    public GameObject Cerradura;
    // Update is called once per frame
    void Update()
    {
        if (PickedObject != null)
        {
            
        }
    }
    private void OnTriggerStay(Collider col)
    {
        if (col.gameObject.CompareTag("Cube1"))
        {
            if (Input.GetMouseButtonDown(1) && PickedObject == null)
            {
                Camera.SetActive(true);
                CamerPLayer.SetActive(false);
            }
        }
    }
}
