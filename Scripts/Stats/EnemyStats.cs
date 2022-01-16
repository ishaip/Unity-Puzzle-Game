using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : CharacterStats
{
	public float delay = 0.1f;
	public override void Die()
	{
		base.Die();
		//addd death animation
		DesplayEnemyHealth.instance.UpdateEnemyHealth(0);
		StartCoroutine(DeathDelay(delay));
		Destroy(gameObject);

	}



		IEnumerator DeathDelay(float delay)
	{

			yield return new WaitForSeconds(delay);
			
	}




}
