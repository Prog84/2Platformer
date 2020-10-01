using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    [SerializeField] private Transform _leftBorder;
    [SerializeField] private Transform _rightBorder;
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody2D _rigidbodyEnemy;
    private bool _isRightDirection;
    private void Update()
    {
        if (transform.position.x > _rightBorder.position.x)
        {
            _isRightDirection = false;
        }
        else if (transform.position.x < _leftBorder.position.x)
        {
            _isRightDirection = true;
        }
        _rigidbodyEnemy.velocity = _isRightDirection ? Vector2.right : Vector2.left;
        _rigidbodyEnemy.velocity *= _speed;
    }

}
