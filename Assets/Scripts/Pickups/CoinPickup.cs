using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
///sets difficuly level
///</summary>
public class CoinPickup : Pickup 

{
    private void OnTriggerEnter2D(Collider2D collision)
    {
		if (collision.tag == "Player" && collision.gameObject.GetComponent<Health>() != null)
		{
		    GameManager.AddCoin(1);
		}
		base.DoOnPickup(collision);
    }
}
