using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionesPuntos : MonoBehaviour
{
    
    public GameObject objectToSpawn;
 
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("CuboBola"))
        {
            collision.gameObject.SetActive(false);
            gameObject.SetActive(!gameObject.activeSelf);
        }
       /* if (collision.gameObject.tag.Equals("Bola"))
            Destroy(collision.gameObject);
        Debug.Log(collision.gameObject.name);*/
        //Instantiate(gameObject);
    }
    private void OnDisable()
    {
        Debug.Log("ok no esta");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Ya no estoy tocando : " + collision.gameObject.name);
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log(string.Format("Estoy tocando el {0}", collision.gameObject.name));
    }

        
   


}