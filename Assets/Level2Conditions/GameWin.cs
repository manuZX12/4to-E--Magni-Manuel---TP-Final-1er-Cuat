using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWin : MonoBehaviour
{
    public GameObject Cube1;
    public Vector3 ValoresDePocicion;
    public GameObject Door;
    public string Nom;
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
        if(collision.transform.name == Nom)
        {
            Cube1.transform.Translate(ValoresDePocicion);
            Door.transform.Translate(-0.1f, 0, 0);
            Destroy(Door);
        }
    }
}
