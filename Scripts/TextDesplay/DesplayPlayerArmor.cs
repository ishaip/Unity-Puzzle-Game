using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesplayPlayerArmor : MonoBehaviour
{
	public PlayerStats PlayerStats;


	void Update()
	{
		string number = PlayerStats.armor.GetValue().ToString();
		GetComponent<TextMesh>().text = number;
	}
}
