using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text puntos;
    public int heladitos;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        puntos.text = heladitos.ToString();
    }

    public void  agarrar()
    {
        heladitos += 1;
    }
}
