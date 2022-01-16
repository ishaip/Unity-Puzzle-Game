using UnityEngine;

public class PlayerStats : CharacterStats

{
	public static PlayerStats instance;
	void Awake ()
	{
		currentHealth=maxHealth;
		instance = this;
	}


	public void AddItem(Item item)
	{
		if (item.name == "sword")
  		{
  			damage.AddModifier(1);
  			Debug.Log("adding 1 damage");
  		}
  		if (item.name == "shield")
  		{
  			armor.AddModifier (1);
  			Debug.Log("adding 1 armor");
  		}

  		if (item.name == "heart")
  		{
  			currentHealth += 1;
  			Debug.Log("adding 1 health");
  		}
  	//return true;
  	}

  	public override void Die()
  	{
  		base.Die();
  		PlayerManager.instance.KillPlayer();
  	}
  	


}
