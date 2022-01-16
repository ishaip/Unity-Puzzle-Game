using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesplayPlayerHealth : MonoBehaviour
{
	public PlayerStats PlayerStats;


	void Update()
	{
		string number = PlayerStats.currentHealth.ToString();
		GetComponent<TextMesh>().text = number;
	}
}
