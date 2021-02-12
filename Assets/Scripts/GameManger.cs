using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    public GameObject dollyCam;
    public List<ParticleSystem> allParticles;
    public Light fireLight;

    void Start()
    {
        StartCoroutine(IntroShot());
    }


    IEnumerator IntroShot()
    {
        yield return new WaitForSeconds(11);
        dollyCam.SetActive(false);
        foreach (ParticleSystem particle in allParticles)
        {
            particle.Stop();
        }

        //fireLight.enabled = false;
    }
}