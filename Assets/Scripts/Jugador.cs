using UnityEngine;
using System.Collections;
using DG.Tweening;
public class Jugador : MonoBehaviour {

    public Vector2 posAct;
    public Vector2 posAnt;
    public Vector2 inercia
    {
        get
        {
            return posAct - posAnt;
        }
    }

    public GameObject botonera;

    public int turnos = 0;

    public bool isMoving;

    public void Start()
    {
        posAct = transform.position;
        posAnt = posAct; 
    }

    public void movement(Vector2 v)
    {
        
        posAnt = posAct;
        posAct = v;
        Debug.Log(v);

        isMoving = true;
        gameObject.transform.DOMove(posAct, 2f).OnComplete(FinMovimiento);
    }

    private void FinMovimiento()
    {
        isMoving = false;
        GameMaster.instance.estadoActual = GameMaster.EstadosJuego.SIGUIENTE_JUGADOR;
    }
}
