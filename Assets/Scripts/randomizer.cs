using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomizer : MonoBehaviour
{
    public GameObject myPlatform;

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
        float randomPositionX1 = Random.Range(-20, 21);
        myPlatformClone = Instantiate(myPlatform, new Vector3(randomPositionX1, 0, 22), Quaternion.identity); // Quaternion identity hace que la rotacion del objeto sea la misma que la del prefab, no es necesario pero si lo es para poner el vector3 en esta linea
        myPlatformClone.name = "platform1";

        //float randomPositionX2 = Random.Range(-20, 21);
        //myPlatformClone2 = Instantiate(myPlatform, new Vector3(randomPositionX2, 0, 42), Quaternion.identity);
        //myPlatformClone2.name = "platform2";

        //float randomPositionX3 = Random.Range(-20, 21);
        //myPlatformClone3 = Instantiate(myPlatform, new Vector3(randomPositionX3, 0, 62), Quaternion.identity);
        //myPlatformClone3.name = "platform3";

        //float randomPositionX4 = Random.Range(-20, 21);
        //myPlatformClone4 = Instantiate(myPlatform, new Vector3(randomPositionX4, 0, 82), Quaternion.identity);
        //myPlatformClone4.name = "platform4";

        //float randomPositionX5 = Random.Range(-20, 21);
        //myPlatformClone5 = Instantiate(myPlatform, new Vector3(randomPositionX5, 0, 102), Quaternion.identity);
        //myPlatformClone5.name = "platform5";

        //float randomPositionX6 = Random.Range(-20, 21);
        //myPlatformClone6 = Instantiate(myPlatform, new Vector3(randomPositionX6, 0, 122), Quaternion.identity);
        //myPlatformClone6.name = "platform6";

        //float randomPositionX7 = Random.Range(-20, 21);
        //myPlatformClone7 = Instantiate(myPlatform, new Vector3(randomPositionX7, 0, 142), Quaternion.identity);
        //myPlatformClone7.name = "platform7";

        //float randomPositionX8 = Random.Range(-20, 21);
        //myPlatformClone8 = Instantiate(myPlatform, new Vector3(randomPositionX8, 0, 162), Quaternion.identity);
        //myPlatformClone8.name = "platform8";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
