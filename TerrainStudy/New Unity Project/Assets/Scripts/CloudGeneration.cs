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
        numClouds = Random.Range(10,20); //random number of clouds generated
        GenerateClouds();
    }

    // Update is called once per frame
    void Update()
    {
        CloudMovement();
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

    void CloudMovement()
    {
        Vector3 xChange = new Vector3(0.08f ,0,0);
        Vector3 zChange = new Vector3(0,0,0.08f );

        for (int i = 0; i < numClouds; i++)
        {
            cloudArr[i].transform.position -= new Vector3(0,0,0.05f);

            if (Input.GetKey(KeyCode.W))
            {
                cloudArr[i].transform.position -= zChange;
            }
            if (Input.GetKey(KeyCode.A))
            {
                cloudArr[i].transform.position += xChange;
            }
            if (Input.GetKey(KeyCode.S))
            {
                cloudArr[i].transform.position += zChange;
            }
            if (Input.GetKey(KeyCode.D))
            {
                cloudArr[i].transform.position -= xChange;
            }
        }
    }
}
