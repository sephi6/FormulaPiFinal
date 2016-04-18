using UnityEngine;
using System.Collections;
using System;


public class PositionCalculator : MonoBehaviour {

    public Transform playerPosition;

    public Vector2 posicionActual;
    public Vector2 posicionAnterior;
    public Vector2 vectorSuma= new Vector2 (1,0);
    private Vector2 finalFlecha;

    public bool firstTime = true;

    public GameObject button;


    private Vector2[] posiblesPosiciones= new Vector2[9];
	// Use this for initialization
	void Start () {

        //getButtonDown(KeyCode.down);

        generaPuntos(new Vector2(playerPosition.position.x, playerPosition.position.y));
        //firstTime = true;
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void generaPuntos(Vector2 v)
    {
        calculaPosicion(v);
        GameMaster.instance.Jugadores[GameMaster.instance.IDJugadorActual].botonera.transform.position = finalFlecha;
       // destroyButtons();
        
    }
            
            

        
    //void destroyButtons()
    //{
    //    //GameObject[] buttons = GameObject.FindGameObjectsWithTag("Button");
    //    foreach (GameObject i in buttons)
    //    {
    //        DestroyObject(i);

    //    }
    //}

   
    void calculaPosicion(Vector2 v)
    {
        Debug.Log(firstTime);

        posicionAnterior = posicionActual;
        
        posicionActual.x = v.x;
        posicionActual.y = v.y;
        Debug.Log("Actual" + posicionActual);

        if (firstTime == false)
        {
            Debug.Log("Entra if  vector suma");
            Debug.Log("Actual" + posicionActual + "Anterior" + posicionAnterior);

            vectorSuma.x = (posicionActual.x - posicionAnterior.x);
            vectorSuma.y = (posicionActual.y - posicionAnterior.y);
            Debug.Log("VS" + vectorSuma);

        }

        firstTime = false;

        
        
        finalFlecha = posicionActual + vectorSuma;
        
        Debug.Log("Actualizo posición anterior" + posicionAnterior);
        
        


        //for (int i = 0; i < 9; i++)
        //{
        //    switch(i){

        //        case 0: 
        //            posiblesPosiciones[i] = finalFlecha + new Vector2(-1, -1);
        //            break;
        //        case 1: 
        //            posiblesPosiciones[i] = finalFlecha + new Vector2(0, -1);
        //            break;
        //        case 2: 
        //            posiblesPosiciones[i] = finalFlecha + new Vector2(1, -1);
        //            break;
        //        case 3: 
        //            posiblesPosiciones[i] = finalFlecha + new Vector2(-1, 0);
        //            break;
        //        case 4:
        //            posiblesPosiciones[i] = finalFlecha;
        //            break;
        //        case 5: 
        //            posiblesPosiciones[i] = finalFlecha + new Vector2(1,0);
        //            break;
        //        case 6: 
        //            posiblesPosiciones[i] = finalFlecha + new Vector2(-1, 1);
        //            break;
        //        case 7: 
        //            posiblesPosiciones[i] = finalFlecha + new Vector2(0, 1);
        //            break;
        //        case 8: 
        //            posiblesPosiciones[i] = finalFlecha + new Vector2(1, 1);
        //            break;
        //    }

            
        //}

    }
}
