using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arco : MonoBehaviour
{
    public GameObject arrowPrefab; // Prefab de la flecha
    public Transform spawnPoint;   // Punto de origen de la flecha
    public float launchForce = 10f; // Fuerza inicial del disparo
    public float angle = 45f;       // �ngulo de disparo en grados

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Asumiendo que el bot�n de disparo es el clic izquierdo del rat�n
        {
            ShootArrow();
        }
    }

    void ShootArrow()
    {
        // Instanciar la flecha
        GameObject arrowInstance = Instantiate(arrowPrefab, spawnPoint.position, spawnPoint.rotation);

        // Obtener el Rigidbody de la flecha
        Rigidbody rb = arrowInstance.GetComponent<Rigidbody>();

        // Calcular la direcci�n y fuerza del disparo
        float angleInRadians = angle * Mathf.Deg2Rad;
        Vector3 launchDirection = new Vector3(Mathf.Cos(angleInRadians), Mathf.Sin(angleInRadians), 0);

        // Aplicar la fuerza al Rigidbody de la flecha
        rb.velocity = launchDirection * launchForce;
    }
}
