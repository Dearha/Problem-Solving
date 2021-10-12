using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMouse : MonoBehaviour
{
    public float speed = 5;
    private float minX= -9, maxX=9, minY=-5, maxY=5;
    private Vector2 mosPos;

    // Update is called once per frame
    void Update()
    {
        mosPos = Input.mousePosition;
        mosPos = Camera.main.ScreenToWorldPoint(mosPos);

        if (mosPos.x > minX && mosPos.x < maxX && mosPos.y > minY && mosPos.y < maxY)
        {
            transform.position = Vector2.MoveTowards(transform.position, mosPos, speed * Time.deltaTime);
        }
        else
        {
            return;
        }
    }
}
