using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Claims;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class PlayerAimFlip : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;

    private TopDownController controller;

    private void Awake()
    {
        controller = GetComponent<TopDownController>();

    }
    private void Start()
    {
        controller.OnLookEvent += Aim;
    }

    private void Aim(Vector2 vector)
    {
        FlipPlayer(vector);
    }

    private void FlipPlayer(Vector2 vector)
    {
        float rotZ = Mathf.Atan2(vector.y, vector.x)*Mathf.Rad2Deg;

        spriteRenderer.flipX = Mathf.Abs(rotZ) > 90f;

    }
}
