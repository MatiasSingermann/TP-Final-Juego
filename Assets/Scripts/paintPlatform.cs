using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paintPlatform : MonoBehaviour
{
    public Material White;
    public Material Red;
    public Material Blue;
    public Material Yellow;
    public Material Green;
    public Collider myCollider;

    // Start is called before the first frame update
    void Start()
    {
        float rng = Random.Range(1, 4);

        myCollider = GetComponent<BoxCollider>();

        // myCollider.enabled = false;

        if (rng == 1)
        {
            GetComponent<Renderer>().material = Red;
        }
        if (rng == 2)
        {
            GetComponent<Renderer>().material = Blue;
        }
        if (rng == 3)
        {
            GetComponent<Renderer>().material = Yellow;
        }
        if (rng == 4)
        {
            GetComponent<Renderer>().material = Green;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if(GetComponent<Renderer>().material == Red || GetComponent<Renderer>().material == Blue || GetComponent<Renderer>().material == Yellow || GetComponent<Renderer>().material == Green)
        //{
        //    myCollider.enabled = false;
        //}
        //if (GetComponent<Renderer>().material == White)
        //{
        //    myCollider.enabled = true;
        //}
    }

    void OnCollisionEnter(Collision playerPlatform)
    {
        Debug.Log("toca");
        if (playerPlatform.gameObject.name == "FPSController")
        {
            if (GetComponent<Renderer>().material == Red || GetComponent<Renderer>().material == Blue || GetComponent<Renderer>().material == Yellow || GetComponent<Renderer>().material == Green)
            {
                Debug.Log("no toca");
                myCollider.enabled = false;
            }
            if (GetComponent<Renderer>().material == White)
            {
                Debug.Log("toca");
                myCollider.enabled = true;
            }
        }
    }
}
