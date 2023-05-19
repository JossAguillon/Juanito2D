using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generadorMoneda : MonoBehaviour
{
    public GameObject juanito, moneda;
    float tiempo=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        if (tiempo >= 5)
        {
            tiempo=0;
            float x=UnityEngine.Random.Range(juanito.transform.position.x+5, juanito.transform.position.x+10);
            float y=UnityEngine.Random.Range(juanito.transform.position.y+1, juanito.transform.position.y+4);

            Instantiate(moneda, new Vector3(x,y,0), new Quaternion());
        }
    }
}
