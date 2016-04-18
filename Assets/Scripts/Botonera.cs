using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Botonera : MonoBehaviour {

    public List<Boton> botones;


	// Use this for initialization
	void Start () {
        botones = new List<Boton>();
        for (int i = 0; i < transform.childCount; i++)
        {
            botones.Add(transform.GetChild(i).GetComponent<Boton>());
        }
	}
	
	
}
