using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomizer : MonoBehaviour
{
    public GameObject myPlatform;
    public GameObject myPlatform2;
    public GameObject myPlatform3;
    public GameObject myPlatform4;
    public GameObject myPlatform5;
    public GameObject myPlatform6;
    public GameObject myPlatform7;
    public GameObject myPlatform8;
    GameObject myPlatformClone;
    GameObject myPlatformClone2;
    GameObject myPlatformClone3;
    GameObject myPlatformClone4;
    GameObject myPlatformClone5;
    GameObject myPlatformClone6;
    GameObject myPlatformClone7;
    GameObject myPlatformClone8;

    // Start is called before the first frame update
    void Start()
    {
        float randomPositionX1 = Random.Range(-20, 20);
        myPlatformClone = Instantiate(myPlatform);
        myPlatformClone.transform.position = new Vector3(randomPositionX1, 2, 22);

        float randomPositionX2 = Random.Range(-20, 20);
        myPlatformClone2 = Instantiate(myPlatform2);
        myPlatformClone2.transform.position = new Vector3(randomPositionX2, 2, 42);

        float randomPositionX3 = Random.Range(-20, 20);
        myPlatformClone3 = Instantiate(myPlatform3);
        myPlatformClone3.transform.position = new Vector3(randomPositionX3, 2, 62);

        float randomPositionX4 = Random.Range(-20, 20);
        myPlatformClone4 = Instantiate(myPlatform4);
        myPlatformClone4.transform.position = new Vector3(randomPositionX4, 2, 82);

        float randomPositionX5 = Random.Range(-20, 20);
        myPlatformClone5 = Instantiate(myPlatform5);
        myPlatformClone5.transform.position = new Vector3(randomPositionX5, 2, 102);

        float randomPositionX6 = Random.Range(-20, 20);
        myPlatformClone6 = Instantiate(myPlatform6);
        myPlatformClone6.transform.position = new Vector3(randomPositionX6, 2, 122);

        float randomPositionX7 = Random.Range(-20, 20);
        myPlatformClone7 = Instantiate(myPlatform7);
        myPlatformClone7.transform.position = new Vector3(randomPositionX7, 2, 142);

        float randomPositionX8 = Random.Range(-20, 20);
        myPlatformClone8 = Instantiate(myPlatform8);
        myPlatformClone8.transform.position = new Vector3(randomPositionX8, 2, 162);

        //float randomPositionX1 = Random.Range(-20, 20);
        //float randomPositionX2 = Random.Range(-20, 20);
        //float randomPositionX3 = Random.Range(-20, 20);
        //float randomPositionX4 = Random.Range(-20, 20);
        //float randomPositionX5 = Random.Range(-20, 20);
        //float randomPositionX6 = Random.Range(-20, 20);
        //float randomPositionX7 = Random.Range(-20, 20);
        //float randomPositionX8 = Random.Range(-20, 20);
        //myPlatformClone.transform.position = new Vector3(randomPositionX1, 2, 22);
        //myPlatformClone.transform.position = new Vector3(randomPositionX2, 2, 42);
        //myPlatformClone.transform.position = new Vector3(randomPositionX3, 2, 62);
        //myPlatformClone.transform.position = new Vector3(randomPositionX4, 2, 82);
        //myPlatformClone.transform.position = new Vector3(randomPositionX5, 2, 102);
        //myPlatformClone.transform.position = new Vector3(randomPositionX6, 2, 122);
        //myPlatformClone.transform.position = new Vector3(randomPositionX7, 2, 142);
        //myPlatformClone.transform.position = new Vector3(randomPositionX8, 2, 162);
        //myPlatformClone = Instantiate(myPlatform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
