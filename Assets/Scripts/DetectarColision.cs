using UnityEngine;

// public class DetectarColision : MonoBehaviour
// {
//     void OnCollisionEnter(Collision collision)
//     {
//        Debug.Log("Colisión detectada con: " + collision.gameObject.name);

//        GetComponent<Renderer>().material.color = Color.red; // Cambia el color del cubo a rojo
//     }
// }

public class DetectarTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider otroObjeto)
    {
       Debug.Log("Entro en contacto con: " + otroObjeto.gameObject.name);

       GetComponent<Renderer>().material.color = Color.blue; // Cambia el color del cubo a rojo
    }
}