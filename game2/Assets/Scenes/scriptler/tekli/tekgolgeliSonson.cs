using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class tekgolgeliSonson : MonoBehaviour
{
    int toplamHayvan = 1;
    int ilkHayvan = 0;
    public Animator transistionAnim;

    public void levelSon()
    {
        ilkHayvan++;
        if (ilkHayvan == toplamHayvan)
        {
            //SceneManager.LoadScene("levelsahne");
            StartCoroutine(LoadScene());
        }
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator LoadScene()
    {
        //source.PlayOneShot(clip);
        //yield return new WaitForSeconds(2f);
        transistionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("levelsahne");

    }
}
