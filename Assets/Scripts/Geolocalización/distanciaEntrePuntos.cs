using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class distanciaEntrePuntos : MonoBehaviour
{
    public GameObject destino;
    public float growthRate;
    private float distancia;

    private AudioSource sonido;
    public AudioClip destinoSonido;
    private bool played = false;

    private int km;
    private int m;
    public TMPro.TextMeshProUGUI texto;

    // Start is called before the first frame update
    void Start()
    {
        sonido = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        
        distancia = Vector3.Distance(transform.position, destino.transform.position) * 111100;
        Debug.Log(distancia);

        float nuevaEscala = proporcionDistanciaTamaño(distancia);
        destino.transform.localScale = new Vector3(nuevaEscala, nuevaEscala, nuevaEscala);

        if (distancia <= 25 && !played)
        {
            sonido.PlayOneShot(destinoSonido);
            played = true;
        }
        else
        {
            if (distancia > 25 && played) played = false;
        }

        km = ((int)distancia / 1000);
        m = (int)distancia % 1000;
        if (km != 0)
            texto.GetComponent<TMPro.TextMeshProUGUI>().text = km.ToString() + "km " + m.ToString() + "m";
        else
            texto.GetComponent<TMPro.TextMeshProUGUI>().text = m.ToString() + "m";
    }

    float proporcionDistanciaTamaño(float distancia)
    {
        return growthRate / distancia;
    }
}
