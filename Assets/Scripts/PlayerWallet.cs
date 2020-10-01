using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.UI;

public class PlayerWallet : MonoBehaviour
{
    private int _scoreCount;
    [SerializeField] private Text _scoreText;
    private void Start()
    {
        _scoreText.text = _scoreCount.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Coin>(out Coin coin))
        {
            _scoreCount += coin.AmountScore;
            _scoreText.text = _scoreCount.ToString();
            Destroy(collision.gameObject);
        }
    }
}

