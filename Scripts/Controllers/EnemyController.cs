using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Enemy))]
public class EnemyController : MonoBehaviour
{
    Transform target;
    NavMeshAgent agent;
    Enemy enemy;
    CharacterCombat combat;

    void Start()
    {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
        combat = GetComponent<CharacterCombat>();
        enemy = GetComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
    	CharacterStats targetStats = target.GetComponent<CharacterStats>();
        float distance = Vector2.Distance(target.position, transform.position);
        float radius = enemy.radius;
        if (distance <= radius)
        {
        	if (targetStats != null)
        	{
        		combat.Attack(targetStats);
        	}
        	
        } 
    }
}
