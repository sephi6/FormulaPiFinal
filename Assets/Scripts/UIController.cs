using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class UIController : MonoBehaviour {

	// Use this for initialization

    public Text textoTurno;
    public GameMaster gameMaster;

    //public static UIController instance;

    public Button aumentaZoom;
    public Button disminuyeZoom;

    public Camera camara;

    public GameObject panelFin;
    public Text ganador;

	void Start () {
        textoTurno.text = null;
        panelFin.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        textoTurno.text = gameMaster.turnoActual.ToString();
	}

    public void aumentaZoomBoton()
    {
        Debug.Log(camara.orthographicSize);
        if (camara.orthographicSize >= 3.5f)
        {
            Debug.Log("Entra +");
            camara.orthographicSize = camara.orthographicSize - 1;
        }
    }

    public void disminuyeZoomBoton()
    {
        if (camara.orthographicSize <= 8f)
            camara.orthographicSize = camara.orthographicSize + 1;
    }

    public void textoGanador(int i)
    {
        panelFin.SetActive(true);
        ganador.text = "Jugador " + i + " gana";
    }
}


