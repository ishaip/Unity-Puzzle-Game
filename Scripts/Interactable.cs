using UnityEngine;

public class Interactable : MonoBehaviour
{
	public float radius = 0.1f;
	public Transform InteractionTransform;

	public Transform player;
	bool hasInteracted = false;


	public virtual void Interact ()
	{
		// this method id meant to be over writen
		//Debug.Log("Interacting with " + transform.name);
	}

	public float GetRadius()
	{
		return radius;
	}


	void Update()
	{
		if (!hasInteracted)
		{
			float distance = Vector2.Distance(player.position, InteractionTransform.position);
			if (distance <= radius)
			{
				Interact();
				hasInteracted = true;
			}
		}
		
	}

	void OnDrawGizmosSelected ()
	{
		if (InteractionTransform == null)
			InteractionTransform = transform;

		
		Gizmos.color = Color.yellow;
		Gizmos.DrawWireSphere(InteractionTransform.position, radius);
	}
}
