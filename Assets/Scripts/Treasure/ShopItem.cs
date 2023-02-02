using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ShopItem : MonoBehaviour
{
    public IntVar money;    //How much money you have
    public int price = 10;  //How much this item costs
                            //Where do we store how much money you have? 
    private Collider2D product;
    public TMP_Text display;

    private void Start()
    {
        display.text = price.ToString();
        
        product = transform.GetComponentsInChildren<Collider2D>()[1];
        product.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (money.value >= price)
        {
            money.value -= price;
            product.enabled = true;
            Destroy(display.transform.parent.gameObject);
            Destroy(this);
        }
    }
}
