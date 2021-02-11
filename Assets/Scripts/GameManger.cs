using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    public GameObject dollyCam;

    void Start()
    {
        StartCoroutine(IntroShot());
    }


    IEnumerator IntroShot()
    {
        yield return new WaitForSeconds(11);
        dollyCam.SetActive(false);
    }

}