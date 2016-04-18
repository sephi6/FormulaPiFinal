using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            Ray r; RaycastHit info;
            r = Camera.main.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(r, out info);

            if (info.collider != null && info.collider.gameObject.tag == "Button")
            {
                // Seleccionar el jugador actual, pero ahora mismo solo tenemos uno.

                GameMaster.instance.estadoActual = GameMaster.EstadosJuego.ESCONDER_BOTONERA;

                GameMaster.instance.Jugadores[GameMaster.instance.IDJugadorActual].movement(info.collider.gameObject.GetComponent<Boton>().GetWorldPosition());
            }

        }


        for (int i = 0; i < Input.touchCount; i++)
        {
            Ray r; RaycastHit info;
            r = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
            Physics.Raycast(r, out info);

            if (info.collider != null && info.collider.gameObject.tag == "Button")
            {
                GameMaster.instance.Jugadores[GameMaster.instance.IDJugadorActual].movement(info.collider.gameObject.GetComponent<Boton>().GetWorldPosition());
            }
        }



	}
}
