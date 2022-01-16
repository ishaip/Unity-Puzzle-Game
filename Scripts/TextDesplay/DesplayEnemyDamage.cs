using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesplayEnemyDamage : MonoBehaviour
{

	public static DesplayEnemyDamage instance;

	void Awake()
	{
		instance = this;
	}

	public void UpdateEnemyDamage(int damage)
	{
		string number = damage.ToString();
		GetComponent<TextMesh>().text = number;
	}
}
