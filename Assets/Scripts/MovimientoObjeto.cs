using UnityEngine;

public class MovimientoObjeto : MonoBehaviour
{

    public float velocidadMovimiento = 5f;
    public float velocidadRotacion = 50f;

    void Update() {
        transform.Translate(Vector3.right * velocidadMovimiento * Time.deltaTime);
        transform.Rotate(Vector3.up * velocidadRotacion * Time.deltaTime);
    }
}
