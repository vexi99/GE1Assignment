using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudGeneration : MonoBehaviour
{
    public GameObject cloud;
    public GameObject[] cloudArr;

    public int numClouds;
    public float[] xCoord;
    public float[] yCoord;
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
        yCoord = new float[numClouds];
        zCoord = new float[numClouds];

        for(int i = 0; i<numClouds ; i++)
        {
            //Generate random x and z coords for cloud
            xCoord[i] = Random.Range(0f,256f);
            yCoord[i] = Random.Range(15f,25f);
            zCoord[i] = Random.Range(0f,256f);

            //cloudArr[i].GetComponent<MeshRenderer>().material.SetColor("_Color",Color.red);

            //Generate random int for scale of cloud
            int randXSize = Random.Range(5,20);
            float randYSize = Random.Range(0.3f, 1f);
            int randZSize = Random.Range(5,20);

            //Instantiate cloud into cloudArr with random X and Z Coords at a set height of 20
            cloudArr[i] = Instantiate(cloud, new Vector3(xCoord[i] , yCoord[i], zCoord[i]), Quaternion.identity);
            cloudArr[i].transform.localScale = new Vector3(randXSize,randYSize, randZSize);

            SetCloudColour(i);
        }
    }

    void SetCloudColour(int i)
    {

        /* Array number i sent from GenerateCloud(), random integer between 0 and 4 exclusive chosen */
        int randColour = Random.Range(0,4);

        if(randColour == 1)
        {
            cloudArr[i].GetComponent<MeshRenderer>().material.SetColor("_Color",Color.white);
        }
        else if(randColour == 2)
        {
            cloudArr[i].GetComponent<MeshRenderer>().material.SetColor("_Color",Color.black);
        }
        else if (randColour == 3)
        {
            cloudArr[i].GetComponent<MeshRenderer>().material.SetColor("_Color",Color.grey);
        }
    }


    void CloudMovement()
    {
        Vector3 xChange = new Vector3(0.08f ,0,0);
        Vector3 zChange = new Vector3(0,0,0.08f );

        for (int i = 0; i < numClouds; i++)
        {
            //keep clouds auto moving
            cloudArr[i].transform.position -= new Vector3(0,0,0.05f);

            //cloud WASD KeyMovement control code
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
