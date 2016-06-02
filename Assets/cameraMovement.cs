using UnityEngine;
using System.Collections;

public class cameraMovement : MonoBehaviour
{

    // Use this for initialization

    public Jugador player;

    
    void Start()
    {
        player = GameMaster.instance.Jugadores[GameMaster.instance.IDJugadorActual];
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("ajajaja"+GameMaster.instance.estadoActual);
        switch (GameMaster.instance.estadoActual)
        {
            case GameMaster.EstadosJuego.INSTANCIACION_BOTONERA: {
                player = GameMaster.instance.Jugadores[GameMaster.instance.IDJugadorActual];
                transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
                //Debug.Log("ID" + GameMaster.instance.IDJugadorActual); 
                break;
            }
            case GameMaster.EstadosJuego.ESCONDER_BOTONERA: { break; }
            case GameMaster.EstadosJuego.MOVIMIENTO:
                Debug.Log("ENTRAAA");
                transform.position= new Vector3(player.transform.position.x,player.transform.position.y, transform.position.z);
               
                break;
            case GameMaster.EstadosJuego.SIGUIENTE_JUGADOR: {
               // Debug.Log("ID" + GameMaster.instance.IDJugadorActual);
                
                break; }
            case GameMaster.EstadosJuego.FIN:

                //Debug.Log("FIN");
                break;

        }
    }
}
