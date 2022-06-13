﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public GameObject hand;
    private GameObject PickedObject;
    public string Room;
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
        if (col.gameObject.CompareTag("FN"))
        {
            if (Input.GetMouseButtonDown(1) && PickedObject == null)
            {
                

                SceneManager.LoadScene("Room4");



            }
        }
    }
    
}

