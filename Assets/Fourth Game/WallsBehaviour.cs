using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsBehaviour : MonoBehaviour
{
    int num;
    public GameObject Wall;
    float Position;
    float Position2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        while(num < 10)
        {
            Position = Random.Range(-6.5f, -34);
            Position2 = Random.Range(0, 9.5f);
            Instantiate(Wall);
            Wall.transform.position = new Vector3 (Position, 0 ,Position2);
            num++;
        }
    }
}
