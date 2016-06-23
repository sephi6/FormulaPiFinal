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
        float ang=Vector2.Angle(posAnt, posAct);
        ang = AngleBetweenVector2(posAnt, posAct);

        transform.DORotate(new Vector3(0, 0, ang - 90), 1f); // el -90 es porque el coche esta girado en el sprite
    }

    

    private float AngleBetweenVector2(Vector2 vec1, Vector2 vec2)
    {
        Vector2 diference = vec2 - vec1;
        float sign = (vec2.y < vec1.y) ? -1.0f : 1.0f;
        return Vector2.Angle(Vector2.right, diference) * sign;
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
