using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempoSonido : MonoBehaviour
{
    public float tiempoSonido;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, tiempoSonido);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
