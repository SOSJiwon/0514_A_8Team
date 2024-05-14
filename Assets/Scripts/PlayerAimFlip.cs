using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAimFlip : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    
    private TopDownController topDownController;

    private void Awake()
    {
        topDownController = GetComponent<TopDownController>();

    }
}
