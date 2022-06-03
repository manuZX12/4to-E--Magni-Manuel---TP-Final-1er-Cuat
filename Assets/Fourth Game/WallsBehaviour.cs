using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsBehaviour : MonoBehaviour
{
    int num;
    public GameObject Wall;
    float Position;
    float Position2;
    float Zposition = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        while(num < 10)
        {
            Position = Random.Range(0, 9);
              
            Instantiate(Wall);
            Wall.transform.position = new Vector3 (Zposition, 0 ,Position);
            num++;
            Zposition = Zposition - 2;
        }
       
    }
}
