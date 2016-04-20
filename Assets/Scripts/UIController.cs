using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

	// Use this for initialization

    public Text textoTurno;
    public GameMaster gameMaster;

	void Start () {
        textoTurno.text = null;
	}
	
	// Update is called once per frame
	void Update () {
        textoTurno.text = gameMaster.turnoActual.ToString();
	}
}
