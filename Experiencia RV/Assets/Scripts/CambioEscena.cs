using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
       if (other.tag == "Player")
        {
            SceneManager.LoadScene("Marte"); 
        }

        Debug.Log("Si colisi�n");
    }
    private void Update()
    {
        
    }
}
