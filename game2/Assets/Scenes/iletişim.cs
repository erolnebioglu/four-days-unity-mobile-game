using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iletişim : MonoBehaviour
{

    public GameObject Panel;
    public GameObject Panel2;

    public void PanelOpener()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
            Panel2.SetActive(!isActive);
        }
    }
    public void kapat()
    {
        Panel.SetActive(false);
        Panel2.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
