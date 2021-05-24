using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota2AudioController : MonoBehaviour
{
    AudioSource[] Sources;
    Rigidbody rb;

    float speed = 0.0f;
    private bool isPlaying = false;
    
    // Start is called before the first frame update
    void Start()
    {
        Sources = GetComponents<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        speed = rb.velocity.magnitude;
        
        if (speed > 0.0f && !isPlaying){
            isPlaying = true;
            Sources[1].Play();
        } 
        if (speed < 0.01f){
            isPlaying = false;
            Sources[1].Stop();
        }

        Sources[1].pitch = speed;
    }
    
    // método llamado por Unity cuando chocamos con algo ...
    void OnCollisionEnter(Collision collision)
    {
        Sources[0].Play();
        
    }
}