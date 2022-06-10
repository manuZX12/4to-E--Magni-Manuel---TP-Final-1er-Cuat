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
        if (collision.gameObject.name == "Key")
        {
            if (transform.position.y > 0.3f)
            {
                BigBox.transform.position = gameObject.transform.position;
                Instantiate(BigBox);
                
                Destroy(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
            
            
        }
    }
}
