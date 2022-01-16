using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DesplayEnemyArmor : MonoBehaviour
{

	public static DesplayEnemyArmor instance;

	void Awake()
	{
		instance = this;
	}

	public void UpdateEnemyArmor(int armor)
	{
		string number = armor.ToString();
		GetComponent<TextMesh>().text = number;
	}
}
