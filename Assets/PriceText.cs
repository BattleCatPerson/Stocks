using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PriceText : MonoBehaviour
{
    public Movement move;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = "Stock Price: $" + move.price.ToString("0.00");
    }
}
