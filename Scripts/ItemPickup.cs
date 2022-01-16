using UnityEngine;

public class ItemPickup : Interactable
{		

	public Item item;
	public CharacterStats stats;
	public override void Interact()
  	{
  		base.Interact();
		PickUp();


  		
  	}
  	void PickUp()
  	{
  		Debug.Log("Picking up " + item.name);
  		//bool wasPickedUP = Inventory.instance.Add(item);
  		//my own cahnge
  		PlayerStats.instance.AddItem(item);
  		Destroy(gameObject);


  		//if (wasPickedUP)
  		//{
		//	Destroy(gameObject);
  		//}
  		
  	}

  
}
