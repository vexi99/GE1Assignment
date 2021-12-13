using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudGeneration : MonoBehaviour
{
    public GameObject cloud;
    public GameObject[] cloudArr;

    public int numClouds;
    public float[] xCoord;
    public float[] zCoord;

    // Start is called before the first frame update
    void Start()
    {
        numClouds = Random.Range(0,20); //random 
        GenerateClouds();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    void GenerateClouds()
    {
        cloudArr = new GameObject[numClouds];
        xCoord = new float[numClouds];
        zCoord = new float[numClouds];
        for(int i = 0; i<numClouds ; i++)
        {
            //Generate random x and z coords for cloud
            xCoord[i] = Random.Range(0f,256f);
            zCoord[i] = Random.Range(0f,256f);

            //Generate random int for scale of cloud
            int randSize = Random.Range(5,20);

            //Instantiate cloud into cloudArr with random X and Z Coords at a set height of 20
            cloudArr[i] = Instantiate(cloud, new Vector3(xCoord[i] , 20, zCoord[i]), Quaternion.identity);
            cloudArr[i].transform.localScale = new Vector3(randSize,0.5f, randSize);
        }
    }
}
