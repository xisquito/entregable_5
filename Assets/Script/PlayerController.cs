using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 initialPos = Vector3.zero;
    private float speed = 10f;
    private float verticalInput;
    private float turnSpeed = 20f;
    private float zMax;
    



    // Start is called before the first frame update
    void Start()
    {
        //Posicion inicial a 0, 0, 0
        transform.position = initialPos;

    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento constante hacia delante
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        verticalInput = Input.GetAxis("Vertical");

        if (zMax >= 50)
        {
            Debug.Log($"THE END");
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            
        }

        if (Input.GetKeyDown(KeyCode.S))
        {

        }
        

    }
}
