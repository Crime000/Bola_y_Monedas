using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbita : MonoBehaviour
{

    public GameObject muro;
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void FixedUpdate()
    {
        transform.RotateAround(muro.transform.position, Vector3.up, velocidad * Time.fixedDeltaTime);
    }
}
