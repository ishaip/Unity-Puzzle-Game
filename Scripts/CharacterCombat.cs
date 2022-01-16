using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterStats))]
public class CharacterCombat : MonoBehaviour
{
	public float attackSpeed = 1f;
	private float attackCooldown = 0f;
	private CharacterStats myStats;

	public float attackDealy = 0.6f;

	public event System.Action OnAttack;

	void Start()
	{
		myStats = GetComponent<CharacterStats>();
	}

	void Update()
	{
		attackCooldown -= Time.deltaTime;
		myStats = GetComponent<CharacterStats>();
	}

	public void Attack (CharacterStats targetStats)
	{
		if (attackCooldown <= 0f)
		{

			StartCoroutine(DoDamage(targetStats, attackDealy));

			if (OnAttack !=null)
			{
				OnAttack();
			}

			attackCooldown = 1f / attackSpeed;
		}
	}


	IEnumerator DoDamage(CharacterStats stats, float delay)
	{
		if (stats != null && myStats != null)
		{
			Debug.Log("myStats");
			yield return new WaitForSeconds(delay);
			stats.TakeDamage(myStats.damage.GetValue());
		}
			
	}

}
