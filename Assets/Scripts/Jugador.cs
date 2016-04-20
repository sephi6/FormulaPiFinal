using UnityEngine;
using System.Collections;
using DG.Tweening;
public class Jugador : MonoBehaviour {

    public Vector2 posAct;
    public Vector2 posAnt;

    //public Vector2 posColision;

    Tweener movimientoActual;

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
        //posColision = posAnt;
        turnos = 0;
    }

    public void movement(Vector2 v)
    {
        //posColision = posAnt;
        posAnt = posAct;
        posAct = v;
        Debug.Log(v);

        isMoving = true;
        //gameObject.transform.DOMove(posAct, 2f).OnComplete(FinMovimiento);
        Tween movimientoActual = gameObject.transform.DOMove(posAct, 2f).SetId("movimientoActual").OnComplete(FinMovimiento);
    }

    private void FinMovimiento()
    {
        isMoving = false;
        GameMaster.instance.estadoActual = GameMaster.EstadosJuego.SIGUIENTE_JUGADOR;
    }

    public void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "Obstacle")
        {
            Debug.Log("COLISiÓN");
            DOTween.Kill("movimientoActual");
            isMoving = false;
            gameObject.transform.position = posAnt;
            posAct = posAnt;
            

            GameMaster.instance.estadoActual = GameMaster.EstadosJuego.SIGUIENTE_JUGADOR;
        }
        else
        {
            Debug.Log("Colision amigable");
        }
        
    }
}
