using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController2D _controller;
    private Animator _animator;
    private float horizontalMove = 0f;

    /// <summary>
    /// The movement speed of the player character.
    /// </summary>
    public float MovementSpeed = 40f;
    public bool CanBeControlled = true;

    private void Awake()
    {
        _controller = this.GetComponent<CharacterController2D>();
        _animator = this.GetComponent<Animator>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (CanBeControlled == false) return;

        horizontalMove = Input.GetAxisRaw("Horizontal") * MovementSpeed;

        if (horizontalMove != 0f)
        {
            _animator.SetBool("IsWalking", true);
        }
        else
        {
            _animator.SetBool("IsWalking", false);
        }
    }

    private void FixedUpdate()
    {
        if (CanBeControlled == false) return;

        _controller.Move(horizontalMove * Time.fixedDeltaTime);
    }
}
