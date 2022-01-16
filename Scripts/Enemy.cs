using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(CharacterStats))]
public class Enemy : Interactable
{	
	public int EnemyHealth = 1;
	private PlayerManager playerManager;
	private StatsPanelManager statsPanel;
	private CharacterStats myStats;
	private SpriteRenderer sprite;
	//bool inRange= false;

	void Start()
	{

		statsPanel = StatsPanelManager.instance;
		playerManager = PlayerManager.instance;
		sprite = GetComponent<SpriteRenderer>();
		myStats = GetComponent<CharacterStats>();
	}

	public override void Interact()
	{
		
		base.Interact();
		CharacterCombat playerCombat = playerManager.player.GetComponent<CharacterCombat>();

		if(playerCombat != null)
		{
			StatsPanelManager.instance.UpdateStatsPanel(myStats , sprite);
			playerCombat.Attack(myStats);
		}


	}

		void Update()
	{
		
			float distance = Vector2.Distance(player.position, InteractionTransform.position);
			if (distance <= radius)
			{
				Interact();
				//hasInteracted = true;
			}
		
	}
}
