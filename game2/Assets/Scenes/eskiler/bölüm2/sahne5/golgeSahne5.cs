using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golgeSahne5 : MonoBehaviour
{
    Camera camera;
    GameObject[] g�lgeler;
    Vector2 baslang�cPos;
    dortluSonrakisahne sonScript;

    void Start()
    {
        camera = GameObject.Find("camera").GetComponent<Camera>();
        g�lgeler = GameObject.FindGameObjectsWithTag("golge");
        baslang�cPos = transform.position;
        sonScript = GameObject.Find("son").GetComponent<dortluSonrakisahne>();

    }
    void OnMouseDrag()
    {
        Vector3 position = camera.ScreenToWorldPoint(Input.mousePosition);
        position.z = 0;
        transform.position = position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            foreach (GameObject golge in g�lgeler)
            {
                if (gameObject.name == golge.name)
                {
                    float mesafe = Vector3.Distance(golge.transform.position, transform.position);
                    if (mesafe <= 1)
                    {
                        transform.position = golge.transform.position;
                        Destroy(this);
                        sonScript.levelSon();



                    }


                    else
                    {
                        transform.position = baslang�cPos;
                    }


                }
            }
        }

    }
}
