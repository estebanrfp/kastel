﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	public float speed;

	void FixedUpdate ()
		{
			float moveHorizontal = Input.GetAxis("Horizontal");
			float moveVertical = Input.GetAxis("Vertical");
			
			Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
			
			GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
		}
	void OnTriggerEnter(Collider other) {
	{
		if(other.gameObject.tag == "PickUp")
		{
			other.gameObject.SetActive(false);
		}
	}
}
}