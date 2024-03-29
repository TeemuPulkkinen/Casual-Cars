﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 touchPosition;
    private Rigidbody2D rb;
    private BoxCollider2D boxCollider;
    private Vector3 direction;
    [SerializeField]
    private float moveSpeed = 3f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0;
            direction = touchPosition - transform.position;
            Vector2 movementVector = new Vector2(direction.x, direction.y);
            rb.velocity = movementVector * moveSpeed;

            if (touch.phase == TouchPhase.Ended)
            {
                rb.velocity = Vector2.zero;
            }
        }

    }

}
