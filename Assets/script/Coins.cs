using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            MoneyText.Coin += 1;
            PlayerPrefs.SetInt("coins", MoneyText.Coin);
            Destroy(gameObject);
        }
        else if (MoneyText.Coin >= 100)
        {
            MoneyText.Coin = 0;
        }
    }
}