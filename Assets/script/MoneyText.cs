using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoneyText : MonoBehaviour
{
    public static int Coin=0;
    Text text;
    // Start is called before the first frame update
    void Start()
    {
       
        text = GetComponent<Text>();
        Coin = PlayerPrefs.GetInt("coins", Coin);
    }

    // Update is called once per frame
    void Update()
    {
        text.text = Coin.ToString ();
    }
}
