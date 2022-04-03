using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
///sets difficuly level
///</summary>
public class JumpPickup : MonoBehaviour
{
	public GameObject JumpP;
	public GameObject pickUpEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
		if (collision.tag == "Player" && collision.gameObject.GetComponent<Health>() != null)
		{
			collision.GetComponent<PlayerController>().SetJumps(1);
		}
		DoOnPickup(collision);
    }
    public virtual void DoOnPickup(Collider2D collision)
   	{
	    if (collision.tag == "Player")
	    {
	        if (pickUpEffect != null)
	        {
	            Instantiate(pickUpEffect, transform.position, Quaternion.identity, null);
	        }
	    }
	}

    public void SetActivity(bool ac)
    {
	    JumpP.SetActive(ac);
    }
}