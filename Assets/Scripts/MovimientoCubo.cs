using UnityEngine;

public class MovimientoCubo : MonoBehaviour
{
    public float movimiento = 5f; // velocidad de movimiento

    void Update()
    {
        float movX = Input.GetAxis("Horizontal") * movimiento * Time.deltaTime;
        float movZ = Input.GetAxis("Vertical") * movimiento * Time.deltaTime;

        transform.Translate(movX, 0, movZ);
    }
}
