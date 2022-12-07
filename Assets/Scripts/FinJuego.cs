using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinJuego : MonoBehaviour
{
    public GameObject GameOverSound;
  
 
    // Start is called before the first frame update
    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("CuboBola"))
        {
            collision.gameObject.SetActive(false);
     
            Instantiate(GameOverSound);
            
        }
        else if (collision.gameObject.tag.Equals("Cubo"))
        {
            Debug.Log("scascasca");
            collision.gameObject.SetActive(false);
            Instantiate(GameOverSound);
        }

    }*/

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Holaaaaaaa");
        if (other.gameObject.tag.Equals("CuboBola"))
        {
            other.gameObject.SetActive(false);
            SceneManager.LoadScene(0);
            Instantiate(GameOverSound);

        }
        else if (other.gameObject.tag.Equals("Cubo"))
        {
            Debug.Log("scascasca");
            other.gameObject.SetActive(false);
            SceneManager.LoadScene(0);

            Instantiate(GameOverSound);
        }

    }
}
