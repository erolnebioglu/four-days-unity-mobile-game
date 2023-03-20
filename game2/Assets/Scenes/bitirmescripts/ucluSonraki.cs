using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ucluSonraki : MonoBehaviour
{
    int toplamHayvan = 3;
    int ilkHayvan = 0;

    public void levelSon()
    {
        ilkHayvan++;
        if (ilkHayvan == toplamHayvan)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
