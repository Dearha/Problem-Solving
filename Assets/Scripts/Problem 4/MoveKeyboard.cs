using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveKeyboard : MonoBehaviour
{
    private float speed = 3;
    private float horizontal;
    private float vertical;

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        transform.Translate(horizontal * speed * Time.deltaTime, vertical * speed * Time.deltaTime, 0);
    }
}
