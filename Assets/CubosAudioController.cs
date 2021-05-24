using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubosAudioController : MonoBehaviour
{
    AudioSource[] Sources;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Sources = GetComponents<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    // método llamado por Unity cuando chocamos con algo ...
    void OnCollisionEnter(Collision collision)
    {
        Sources[0].Play();
        
    }
}