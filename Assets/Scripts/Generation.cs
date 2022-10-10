using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generation : MonoBehaviour
{
    public int height, width;
    public GameObject platform;
 

    int num;

    // Start is called before the first frame update
    void Start()
    {
        Generations();
    }


    void Generations()
    {
        // The actual procedual generation accross the y-axis 
        for (int y = 0; y < height; y++)
        {
         
            // Generation on the x-axis
            for(int x = 0; x<width; x++)
            {
                SpawnObj(platform, x+4, y+2);
            }
            SpawnObj(platform,0,y+2);
      
            
        }
    }

    // Function for spawning in game objects 
    void SpawnObj(GameObject obj,int x ,int y)
    {
        obj = Instantiate(obj, new Vector2(x,y), Quaternion.identity);
        obj.transform.parent = this.transform;
    }
}
