using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
	public static PlayerManager instance;

	void Awake()
	{
		instance = this;
	}

	public GameObject player;
	public DesplayEnemyArmor armor;

	public void KillPlayer()
	{
		
		//Destroy(player);
		//StartCoroutine(Respawn());
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	IEnumerator Respawn()
	{
		//Debug.Log("im here");
			yield return new WaitForSeconds(300f);
	}

}
