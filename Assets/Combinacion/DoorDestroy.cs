using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorDestroy : MonoBehaviour
{
    public GameObject NumeroMID;
    public GameObject NumeroIZ;
    public GameObject NumeroDR;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (NumeroMID.transform.localEulerAngles.y == 90)
        {
            Destroy(gameObject,1);
            Debug.Log("Hola");
        }
    }
}
