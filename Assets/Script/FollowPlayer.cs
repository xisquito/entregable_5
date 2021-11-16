using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(15, 3, 0);
    // Update is called once per frame
    void Update()
    {
        //Sirve para empezar el juego, y que la cámara empieze a seguir el personaje
        transform.position = player.transform.position + offset;
    }
}
