using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 initialPos = Vector3.zero;
    private float speed = 10f;
    private float verticalInput;
    private float turnSpeed = 20f;
    private float zMax = 450f;
    



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

        //Rotacion en el eje X
        verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.right, turnSpeed * Time.deltaTime * verticalInput);

        //Si ZMax pasa de 450, en la consola saldra un mensaje de "The End"
        if (transform.position.z >= zMax)
        {
            Debug.Log(message: "THE END");
            Time.timeScale = 0;
        }





    }
}
