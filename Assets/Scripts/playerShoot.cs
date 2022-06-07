using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerShoot : MonoBehaviour
{
    public GameObject myCamera;
    public GameObject crosshair;

    public AudioSource source;
    public AudioClip spraySound;

    [SerializeField] private Image Crosshair;

    public playerSprayColor scriptPlayerSprayColor; // vincular scripts

    public paintPlatform scriptPaintPlatform;

    // Start is called before the first frame update
    void Start()
    {
        Crosshair.color = new Color(1, 1, 1, 0.75f); // crosshair blanco

        scriptPlayerSprayColor = FindObjectOfType<playerSprayColor>(); // vincular scripts
        
        scriptPaintPlatform = FindObjectOfType<paintPlatform>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        string gameObjectShot;

        if (Physics.Raycast(myCamera.transform.position, myCamera.transform.forward, out hit))
        {
            Vector3 shotPosition = hit.point;
            float shootDistance = hit.distance;
            gameObjectShot = hit.collider.gameObject.name;

            if (hit.transform.gameObject.CompareTag("tagPlatform"))
            {
                Crosshair.color = new Color(1, 0, 0, 0.75f); // crosshair rojo

                if (Input.GetMouseButtonDown(0))
                {
                    source.PlayOneShot(spraySound);

                    if(scriptPlayerSprayColor.selectedColor == 0) // si el spray es rojo
                    {
                        Debug.Log("Contacto Rojo");
                    }
                    if (scriptPlayerSprayColor.selectedColor == 1) // si el spray es azul
                    {
                        Debug.Log("Contacto Azul");
                    }
                    if (scriptPlayerSprayColor.selectedColor == 2) // si el spray es amarillo
                    {
                        Debug.Log("Contacto Amarillo");
                    }
                    if (scriptPlayerSprayColor.selectedColor == 3) // si el spray es verde
                    {
                        Debug.Log("Contacto Verde");
                    }
                }
            }
            else
            {
                Crosshair.color = new Color(1, 1, 1, 0.75f); // crosshair blanco
            }
        }
        else
        {
            Crosshair.color = new Color(1, 1, 1, 0.75f); // crosshair blanco
        }
    }
}
