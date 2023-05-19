using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    Animator animacion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animacion = gameObject.GetComponent<Animator>();

        if (Input.GetKey("right"))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + .1f, gameObject.transform.position.y, gameObject.transform.position.z);
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
            animacion.SetBool("brincar", false);
            animacion.SetBool("correr", true);
        }
        else if (Input.GetKey("left"))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x - .1f, gameObject.transform.position.y, gameObject.transform.position.z);
            gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
            animacion.SetBool("brincar", false);
            animacion.SetBool("correr", true);
        }
        else if (Input.GetKey("up"))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + .1f, gameObject.transform.position.z);
            animacion.SetBool("brincar", true);
            animacion.SetBool("correr", false);
        }
        else
        {
            animacion.SetBool("brincar", false);
            animacion.SetBool("correr", false);
        }
    }
}
