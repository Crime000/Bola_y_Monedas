using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muros : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Roca"))
        {
            Destroy(gameObject);
        }
    }
}
