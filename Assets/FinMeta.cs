using UnityEngine;
using System.Collections;

public class FinMeta : MonoBehaviour
{
    public int ganador;
    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {

            GameMaster.instance.estadoActual = GameMaster.EstadosJuego.FIN;
            
        }
    }
}
