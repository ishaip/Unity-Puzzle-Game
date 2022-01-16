using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesplayEnemySprite : MonoBehaviour
{

	public static DesplayEnemySprite instance;

	void Awake()
	{
		instance = this;
	}

	public void UpdateEnemySprite(SpriteRenderer newSprite)
	{
		GetComponent<SpriteRenderer>().sprite = newSprite.sprite;
	}
}
