using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamreaController : MonoBehaviour
{
	public Transform target;
  public Camera Camera;

	public Vector3 offset;
	public float zoomSpeed = 1f;
	public float minZoom = 1f;
	public float maxZoom = 3f;

	private float currentZoom = 2f;

	void Update ()
    
    { 

    	currentZoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
    	currentZoom = Mathf.Clamp(currentZoom, minZoom,maxZoom);
    }
   	void LateUpdate ()

    {
   		transform.position = target.position;
   		Camera.orthographicSize =  currentZoom;
    }
}
