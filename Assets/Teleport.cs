using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Vector2[] positions;
    int currentPosition;
    int newPosition;

    void Start()
    {
        move();
        EventManager.OnClick += move;
    }

    void move()
    {
        
        newPosition = Random.Range(0, positions.Length);
        if(newPosition != currentPosition)
        {
            gameObject.transform.position = positions[newPosition];
            currentPosition = newPosition;
        }
        else
        {
            move();
        }
    }
}
