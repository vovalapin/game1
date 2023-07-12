using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Win : MonoBehaviour

{
    public static int Coin = 100;
    Text text;
    // Start is called before the first frame update
    void Start()
    {

        text = GetComponent<Text>();
        Coin = PlayerPrefs.GetInt("Win", Coin);
    }

    // Update is called once per frame
    void Update()
    {
        text.text = Coin.ToString();
    }
}
