using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombinatedKeys : MonoBehaviour
{
    public GameObject BigBox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PickedObject")
        {
            if (transform.position.y > 0.3f)
            {
                Instantiate(BigBox);
                BigBox.transform.position = transform.position;
                Destroy(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
            
            
        }
    }
}
