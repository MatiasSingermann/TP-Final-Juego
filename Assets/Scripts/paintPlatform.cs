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
    public int numberMaterial;

    // Start is called before the first frame update
    void Start()
    {
        float rng = Random.Range(1, 4);

        myCollider = GetComponent<BoxCollider>();

        // myCollider.enabled = false;

        if (rng == 1)
        {
            GetComponent<Renderer>().material = Red;
            numberMaterial = 1;
        }
        if (rng == 2)
        {
            GetComponent<Renderer>().material = Blue;
            numberMaterial = 2;
        }
        if (rng == 3)
        {
            GetComponent<Renderer>().material = Yellow;
            numberMaterial = 3;
        }
        if (rng == 4)
        {
            GetComponent<Renderer>().material = Green;
            numberMaterial = 4;
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

    //void OnCollisionEnter(Collision playerPlatform)
    //{
    //    Debug.Log("toca");
    //    if (playerPlatform.gameObject.name == "playerCollision")
    //    {
    //        if (numberMaterial == 1 || numberMaterial == 2 || numberMaterial == 3 || numberMaterial == 4)
    //        {
    //            Debug.Log("no toca");
    //            myCollider.enabled = false;
    //        }
    //        if (GetComponent<Renderer>().material == White)
    //        {
    //            Debug.Log("toca");
    //            myCollider.enabled = true;
    //        }
    //    }
    //    else
    //    {
    //        myCollider.enabled = true;
    //    }
    //}
}
