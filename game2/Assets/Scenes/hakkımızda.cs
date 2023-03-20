using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hakkımızda : MonoBehaviour
{
    public Animator transistionAnim;

    public void hakkımızdaac()
    {
        StartCoroutine(LoadScene());

    }
    // Start is called before the first frame update
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
        SceneManager.LoadScene("hakkımızda");

    }
}
