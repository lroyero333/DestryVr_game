using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisiones : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objectToSpawn;
    public GameObject SoundDestruir;
    private int cordenadaX= 1;
    private int cordenadaY = 5;
    private int cordenadaZ =1;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("CuboBola"))
        {
            collision.gameObject.SetActive(false);
            Instantiate(SoundDestruir);
            gameObject.SetActive(!gameObject.activeSelf);
            Instantiate(objectToSpawn);
            objectToSpawn.transform.position = new Vector3(cordenadaX, cordenadaY, cordenadaZ);
        }
        else if (collision.gameObject.tag.Equals("Cubo"))
        {
            collision.gameObject.SetActive(false);
            Instantiate(SoundDestruir);
            gameObject.SetActive(!gameObject.activeSelf);
        }

        Debug.Log(collision.gameObject.name);
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