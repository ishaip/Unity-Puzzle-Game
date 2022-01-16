using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stairs : MonoBehaviour
{
	public float radius = 0.2f;
	public Transform InteractionTransform;
	public Transform player;
	public Transform targetLocation;
	public Stairs target = null;
	private bool prime = true;


	public  void useStairs()
	{
		if (target != null)
		{
					target.prime = false;
		}
		player.position = targetLocation.position;
	}

	public void Update()
	{
		if (prime)
		{
			float distance = Vector2.Distance(player.position, InteractionTransform.position);
			if (distance < radius)
			{
				useStairs();
			}
		}
		if(!prime)
		{

			float distance = Vector2.Distance(player.position, InteractionTransform.position);
			if (distance > radius)
			{
				prime = true;
			}
		}		
	}


	void OnDrawGizmosSelected ()
	{
		if (InteractionTransform == null)
			InteractionTransform = transform;

		
		Gizmos.color = Color.yellow;
		Gizmos.DrawWireSphere(InteractionTransform.position, radius);
	}
}
