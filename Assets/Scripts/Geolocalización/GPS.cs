using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPS : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(StartLocation());
    }

    IEnumerator StartLocation()
    {
        // Espera hasta que esté habilitado el servicio de localización
        while (!Input.location.isEnabledByUser)
        {
            Debug.Log("Es necesario activar el GPS");
            yield return new WaitForSeconds(1f);
        }

        // Inicia el servicio con una precisión deseado de 5m y se actualiza cuando se mueva 10m
        Input.location.Start(5f, 10f);

        // Espera 20 segundos hasta que el servicio se inicialice
        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }

        // La inicialización ha agotado los 20 segundos
        if (maxWait < 1)
        {
            Debug.Log("Timed out");
            yield break;
        }

        if (Input.location.status == LocationServiceStatus.Failed)
        { // La conexión ha fallado
            Debug.Log("Imposible determinar la posición del dispositivo");
            yield break;
        }
        else
        { // Muestra los datos de la localización
            Debug.Log("Location: " + Input.location.lastData.latitude + " " +
            Input.location.lastData.longitude + " " +
            Input.location.lastData.altitude);
        }
    }

    

}
