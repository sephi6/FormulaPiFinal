using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIControllerMenu : MonoBehaviour {

	// Use this for initialization

    public Animator panelMapa;

    public int numJugadores;

    
    

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void abrePanelMapa()
    {
        panelMapa.SetInteger("cierra", 1);

    }

    public void cierraPanelMapa()
    {
        panelMapa.SetInteger("cierra", 0);
    }
}
