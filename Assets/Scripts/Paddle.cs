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
        UpdateTouch();
    }

    private void UpdateTouch()
    {
        if (Input.touchCount <= 0)
            return;

        switch (Input.touches[0].phase)
        {
            case TouchPhase.Began:
                {
                    OnTouchDown();
                }
                break;
            case TouchPhase.Moved:
                {
                    OnTouchDrag();
                }
                break;
            case TouchPhase.Ended:
                {
                    OnTouchUp();
                }
                break;
        }
    }

    private void OnTouchDown()
    {
        posX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
        posY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
    }

    private void OnTouchDrag()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (isPlayer1)
            transform.position = new Vector2(-8, mousePos.y - posY);
        else
            transform.position = new Vector2(8, mousePos.y - posY);
    }

    private void OnTouchUp() { }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}
