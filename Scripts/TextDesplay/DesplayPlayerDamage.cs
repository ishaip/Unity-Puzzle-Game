using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesplayPlayerDamage : MonoBehaviour
{
	public PlayerStats PlayerStats;


	void Update()
	{
		string number = PlayerStats.damage.GetValue().ToString();
		GetComponent<TextMesh>().text = number;
	}
}
