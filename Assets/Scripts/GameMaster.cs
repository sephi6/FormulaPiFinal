using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameMaster : MonoBehaviour {

    public enum EstadosJuego { INSTANCIACION_BOTONERA, MOVIMIENTO, ESCONDER_BOTONERA, SIGUIENTE_JUGADOR };

    public static GameMaster instance; // SINGLETON

    public EstadosJuego estadoActual;

    public List<Jugador> Jugadores;
    public int IDJugadorActual;

	void Start () {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogError("Se ha detectado más de una instancia");
        }
        IDJugadorActual = 0;
        estadoActual = EstadosJuego.INSTANCIACION_BOTONERA;
	}
	
	// Update is called once per frame
	void Update () {

        switch (estadoActual)
        {
            case EstadosJuego.INSTANCIACION_BOTONERA : { InstanciarBotonera(IDJugadorActual); break; }
            case EstadosJuego.ESCONDER_BOTONERA : { EsconderBotonera(IDJugadorActual); break;}
            case EstadosJuego.MOVIMIENTO : break;
            case EstadosJuego.SIGUIENTE_JUGADOR : {SiguienteJugador(); break;}


        }

	}

    void EsconderBotonera(int ID)
    {
        Jugadores[ID].botonera.SetActive(false);
    }


    public int SiguienteJugador()
    {
        IDJugadorActual++;
        IDJugadorActual %= Jugadores.Count;

        estadoActual = EstadosJuego.INSTANCIACION_BOTONERA;
        return IDJugadorActual;
    }


    void InstanciarBotonera(int ID)
    {
        Jugadores[ID].botonera.SetActive(true);
        Jugadores[ID].botonera.transform.position = Jugadores[ID].posAct+Jugadores[ID].inercia;

    }

    
}
