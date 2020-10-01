using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbodyPlayer;
    [SerializeField] private GroundDetection groundDetection;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Animator _animator;
    [SerializeField] private Vector3 _direction;
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    private void Update()
    {
        CheckMove();
        CheckJump();
        _animator.SetFloat("Speed", Mathf.Abs(_direction.x));
    }
    private void CheckMove()
    {
        _direction = Vector3.zero;
        if (Input.GetKey(KeyCode.A))
        {
            _direction = Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            _direction = Vector3.right;
        }

        _direction *= _speed;
        _direction.y = _rigidbodyPlayer.velocity.y;
        _rigidbodyPlayer.velocity = _direction;

        if (_direction.x > 0)
        {
            _spriteRenderer.flipX = false;
        }
        if (_direction.x < 0)
        {
            _spriteRenderer.flipX = true;
        }
    }
    private void CheckJump()
    {
        if (groundDetection.IsGrounded && Input.GetKey(KeyCode.Space))
        {
            _rigidbodyPlayer.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
        }
    }
}
