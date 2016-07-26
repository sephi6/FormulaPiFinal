using UnityEngine;
using System.Collections;

public class animatorPrueba : MonoBehaviour {

    public Animator animator;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.A))
        {
            animator.SetInteger("cabeza", 1);
        }
        else
        {
            animator.SetInteger("cabeza", 0);
        }
	
	}
}
