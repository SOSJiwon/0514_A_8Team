using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private TopDownController controller;
    private Rigidbody2D rigd;
    private float Speed = 5f;

    private Vector2 MovementDirection = Vector2.zero; // 시작하는 기본위치 = 계속해서 바뀔 플레이어의 현재 위치

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
        rigd = GetComponent<Rigidbody2D>();

    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMove(MovementDirection);
    }
    private void Move(Vector2 vector)
    {
        MovementDirection = vector;
    }

    private void ApplyMove(Vector2 direction)
    {
        direction = direction * Speed;
        rigd.velocity = direction;
    }
}
