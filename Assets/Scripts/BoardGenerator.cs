using UnityEngine;
using System.Collections;

public class BoardGenerator : MonoBehaviour {

    public GameObject grid;
    public int widht;
    public int height;

	// Use this for initialization
	void Start () {
        generate();
	}
	
	// Update is called once per frame
    void generate()
    {
        for (int x = 0; x < height; x++)
        {
            for (int y = 0; y < widht; y++)
            {
                //GameObject aux= GameObject.CreatePrimitive(PrimitiveType.Plane);
                //aux.transform.position= new Vector3(x,y,1f);
                
               GameObject aux= (GameObject) Instantiate(grid,new Vector3(x,y,1f),Quaternion.identity);
               aux.transform.parent = this.transform;
           
                
                
                
            }
        }
    }
}
