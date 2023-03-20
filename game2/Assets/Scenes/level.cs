using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class level : MonoBehaviour
{

    public Animator transistionAnim;
    public void seviye1()
    {
        StartCoroutine(LoadScene1());
        //SceneManager.LoadScene("sahne1");
    }
    public void seviye2()
    {
        StartCoroutine(LoadScene2());
        //SceneManager.LoadScene("sahne2");
    }
    public void seviye3()
    {
        StartCoroutine(LoadScene3());
        //SceneManager.LoadScene("sahne3");
    }
    public void seviye4()
    {
        StartCoroutine(LoadScene4());
        //SceneManager.LoadScene("sahne6");
    }
    public void seviye5()
    {
        StartCoroutine(LoadScene5());
        //SceneManager.LoadScene("sahne8");
    }
    IEnumerator LoadScene1()
    {
        //source.PlayOneShot(clip);
        //yield return new WaitForSeconds(2f);
        transistionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("sahne8");

    }
    IEnumerator LoadScene2()
    {
        //source.PlayOneShot(clip);
        //yield return new WaitForSeconds(2f);
        transistionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("ikinci1");

    }
    IEnumerator LoadScene3()
    {
        //source.PlayOneShot(clip);
        //yield return new WaitForSeconds(2f);
        transistionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("ucuncu1");

    }
    IEnumerator LoadScene4()
    {
        //source.PlayOneShot(clip);
        //yield return new WaitForSeconds(2f);
        transistionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("sahne6");

    }
    IEnumerator LoadScene5()
    {
        //source.PlayOneShot(clip);
        //yield return new WaitForSeconds(2f);
        transistionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("bulutlu1");

    }
}
