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
        Vector3 ROCA = new Vector3(roca.transform.position.x, transform.position.y, roca.transform.position.z);
        transform.LookAt(ROCA);
        transform.position = Vector3.MoveTowards(transform.position, ROCA, velocidad * Time.fixedDeltaTime);
        
        
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
