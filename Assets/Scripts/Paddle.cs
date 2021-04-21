using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isPlayer1;
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;
    public Vector2 mousePos;

    private float movement;
    private float posX, posY;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {

        //if (isPlayer1)
        //    movement = Input.GetAxisRaw("Vertical");
        //else
        //    movement = Input.GetAxisRaw("Vertical2");

        //rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }

    private void OnMouseDown()
    {
        posX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
        posY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
    }

    private void OnMouseDrag()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (isPlayer1)
            transform.position = new Vector2(-8, mousePos.y - posY);
        else
            transform.position = new Vector2(8, mousePos.y - posY);
    }

    private void OnMouseUp()
    {

    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}
