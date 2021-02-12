using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerActivate : MonoBehaviour
{
    public ParticleSystem particle;
    
    private void OnTriggerEnter(Collider other)
    {
        particle.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        particle.Stop();
    }
}
