using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fango : MonoBehaviour
{

    public GameObject roca;
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void FixedUpdate()
    {
        transform.LookAt(roca.transform.position);
        transform.position = Vector3.MoveTowards(transform.position, roca.transform.position, velocidad * Time.fixedDeltaTime);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Roca"))
        {
            Destroy(roca);
            Destroy(gameObject);
        }
    }
}
