using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIControllerMenu : MonoBehaviour {

	// Use this for initialization

    public Animator panelMapa;

    public int numJugadores=0;

    public int mapa = 0;


    public void seleccionaPlayers(int a)   {

        numJugadores = a;

    }

    

    

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

    public void cargaMapa(int a)
    {
        mapa = a;
        switch (numJugadores)
        {
            #region Mapas1P
            case 1:
                
                switch (mapa)
                {
                    case 1:
                        SceneManager.LoadScene(3);
                        break;
                    case 2:
                        //CARGA MAPA 1 DE 2P
                        SceneManager.LoadScene(4);
                        break;
                }

                break;
            #endregion
            #region Mapas2P
            case 2:
                switch (mapa)
                {
                    case 1:
                        //CARGA MAPA 2 DE 1P
                        SceneManager.LoadScene(1);
                        break;
                    case 2:
                        //CARGA MAPA 2 DE 2P
                        SceneManager.LoadScene(2);
                        break;
                }
                break;

            #endregion

        }

    }
}
