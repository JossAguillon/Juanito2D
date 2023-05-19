using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    public Transform juanito;
    public float separacion=5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position= new Vector3(juanito.position.x+separacion,
        transform.position.y, transform.position.z);
    }
}
