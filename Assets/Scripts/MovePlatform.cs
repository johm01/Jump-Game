using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    float speed;
    public GameObject[] node;
    int num;
    // Start is called before the first frame update
    void Start()
    {
        num = Random.Range(25, 35);
        transform.position += new Vector3(transform.position.x + num, transform.position.y);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
