using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsPanelManager : MonoBehaviour
{
public static StatsPanelManager instance;

	void Awake()
	{
		instance = this;
	}


	private DesplayEnemyArmor myArmor;
	private DesplayEnemyDamage myDamage;
	private DesplayEnemyHealth myHealth;
	public GameObject statsPanelManager;
	public int damage = 0;
	public int currentHealth = 0;
	public int armor = 0;
	public float combatCooldown = 2f;
	public bool inCombat = false;
	public SpriteRenderer nullSprite;

		void Update()
	{
		combatCooldown -= Time.deltaTime;

		if (combatCooldown < 0 )
		{
			DesplayEnemyDamage.instance.UpdateEnemyDamage(0);
			DesplayEnemyHealth.instance.UpdateEnemyHealth(0);
			DesplayEnemyArmor.instance.UpdateEnemyArmor(0);
			DesplayEnemySprite.instance.UpdateEnemySprite(nullSprite);

		}
	}




	public void UpdateStatsPanel(CharacterStats myStats, SpriteRenderer SpriteRenderer)
	{
		inCombat=true;
		combatCooldown = 2;
		armor = myStats.armor.GetValue();
		DesplayEnemyArmor.instance.UpdateEnemyArmor(armor);
		currentHealth = myStats.currentHealth;
		DesplayEnemyHealth.instance.UpdateEnemyHealth(currentHealth);
		damage = myStats.damage.GetValue();
		DesplayEnemyDamage.instance.UpdateEnemyDamage(damage);
		DesplayEnemySprite.instance.UpdateEnemySprite(SpriteRenderer);
	}
}
