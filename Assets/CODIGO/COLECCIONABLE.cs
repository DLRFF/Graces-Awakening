using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COLECCIONABLE : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "jugador")
        {
            other.gameObject.GetComponent<Score>().agarrar();
            Destroy(gameObject);
        }
    }

}

