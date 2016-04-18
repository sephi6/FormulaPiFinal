using System;
using UnityEngine;
using System.Collections;

public class Boton: MonoBehaviour
{

    public Vector2 GetWorldPosition()
    {
        return new Vector2(transform.parent.position.x + transform.localPosition.x, transform.parent.position.y + transform.localPosition.y);
    }

}

