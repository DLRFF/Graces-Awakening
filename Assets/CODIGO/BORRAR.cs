using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BORRAR : MonoBehaviour
{
    public float initialSpeed = 2f;
    public float acceleration = 0.1f;

    private float currentSpeed;

    private void Start()
    {
        currentSpeed = initialSpeed;
    }

    private void Update()
    {
        // Mover el objeto en línea recta en el eje X (puedes ajustar el eje según tu preferencia)
        transform.Translate(Vector2.right * currentSpeed * Time.deltaTime);

        // Aumentar la velocidad
        currentSpeed += acceleration * Time.deltaTime;
    }

   private void OnCollisionEnter2D(Collision2D collision)  
    {
    // Si el objeto con el que colisiona no es él mismo, destruirlo
        if (collision.gameObject != gameObject)
        {
         Destroy(collision.gameObject);
        }
    }
}