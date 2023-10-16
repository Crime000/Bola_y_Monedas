using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muros : MonoBehaviour
{
    public ParticleSystem fragmentos;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Roca"))
        {
            fragmentos.transform.position = transform.position;
            fragmentos.Play();
            Destroy(gameObject);
        }
    }
}
