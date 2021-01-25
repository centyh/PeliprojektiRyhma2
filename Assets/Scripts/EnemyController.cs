using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    private Rigidbody2D rb;
    private Vector2 movement;
    private Animator animator;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Start()
    {
        
    }


    void Update()
    {
        movement = new Vector2(-transform.position.x * moveSpeed, 0f);
    }
}
