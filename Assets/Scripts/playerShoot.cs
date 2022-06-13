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
    public AudioClip backgroundMusic;

    [SerializeField] private Image Crosshair;

    public playerSprayColor scriptPlayerSprayColor; // vincular scripts

    public paintPlatform scriptPaintPlatform;

    public randomizer scriptRandomizer;

    public GameObject myPlatform;

    // Start is called before the first frame update
    void Start()
    {
        source.PlayOneShot(backgroundMusic);

        Crosshair.color = new Color(1, 1, 1, 0.75f); // crosshair blanco

        scriptPlayerSprayColor = FindObjectOfType<playerSprayColor>(); // vincular scripts
        
        scriptPaintPlatform = FindObjectOfType<paintPlatform>();

        scriptRandomizer = FindObjectOfType<randomizer>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        string gameObjectShot;

        if (Physics.Raycast(myCamera.transform.position, myCamera.transform.forward, out hit, 30f))
        {
            Vector3 shotPosition = hit.point;
            float shootDistance = hit.distance;
            gameObjectShot = hit.collider.gameObject.name;

            Debug.Log(gameObjectShot);

            if (hit.transform.gameObject.CompareTag("tagPlatform"))
            {
                Crosshair.color = new Color(1, 0, 0, 0.75f); // crosshair rojo

                if (Input.GetMouseButtonDown(0))
                {
                    source.PlayOneShot(spraySound);

                    Debug.Log(scriptPaintPlatform.numberMaterial);

                    if(scriptPaintPlatform.numberMaterial == 1 && scriptPlayerSprayColor.selectedColor == 0) // si el spray es rojo
                    {
                        scriptPaintPlatform.GetComponent<Renderer>().material = scriptPaintPlatform.White;
                        Debug.Log("Contacto Rojo");
                        scriptPaintPlatform.numberMaterial = 10;
                    }
                    if (scriptPaintPlatform.numberMaterial == 2 && scriptPlayerSprayColor.selectedColor == 1) // si el spray es azul
                    {
                        scriptPaintPlatform.GetComponent<Renderer>().material = scriptPaintPlatform.White;
                        Debug.Log("Contacto Azul");
                        scriptPaintPlatform.numberMaterial = 10;
                    }
                    if (scriptPaintPlatform.numberMaterial == 3 && scriptPlayerSprayColor.selectedColor == 2) // si el spray es amarillo
                    {
                        scriptPaintPlatform.GetComponent<Renderer>().material = scriptPaintPlatform.White;
                        Debug.Log("Contacto Amarillo");
                        scriptPaintPlatform.numberMaterial = 10;
                    }
                    if (scriptPaintPlatform.numberMaterial == 4 && scriptPlayerSprayColor.selectedColor == 3) // si el spray es verde
                    {
                        scriptPaintPlatform.GetComponent<Renderer>().material = scriptPaintPlatform.White;
                        Debug.Log("Contacto Verde");
                        scriptPaintPlatform.numberMaterial = 10;
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
            Crosshair.color = new Color(1, 1, 1, 0.75f);
        }
    }
}
