using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesplayEnemyHealth : MonoBehaviour
{

	public static DesplayEnemyHealth instance;

	void Awake()
	{
		instance = this;
	}

	public void UpdateEnemyHealth(int health)
	{
		string number = health.ToString();
		GetComponent<TextMesh>().text = number;
	}
}
