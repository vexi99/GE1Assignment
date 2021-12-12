using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public TerrainGenerator terrain;
    public TreeGeneration tree;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("User moving forward");
            terrain.offsetX = terrain.offsetX + 0.02f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("User moving left");
            terrain.offsetY = terrain.offsetY - 0.02f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("User moving backward");
            terrain.offsetX = terrain.offsetX - 0.02f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("User moving right");
            terrain.offsetY = terrain.offsetY + 0.02f;
        }
    }
}
