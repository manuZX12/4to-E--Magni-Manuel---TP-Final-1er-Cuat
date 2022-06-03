using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBehaviour : MonoBehaviour
{
    public GameObject Key1;
    public GameObject Door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision Col)
    {
        if(Col.gameObject.name == "Key")
        {
            Destroy(Key1);
            Destroy (Door);
        }
    }
}
