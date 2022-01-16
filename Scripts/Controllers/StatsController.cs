using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsController : MonoBehaviour
{
  	public Camera mainCamera;
  	public Transform cameraLocation;

	private Vector3 cameraOffset;
	public Vector3 offset;
  public float camreaChangeX;






	void Update ()
    
    { 
    	cameraOffset.y = mainCamera.orthographicSize * 1f;
      cameraOffset.x = mainCamera.orthographicSize * camreaChangeX;
   		transform.position = cameraLocation.position + cameraOffset + offset;
   		//transform.position.y = cameraLocation.position.y;



   	}
}
