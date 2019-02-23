using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIpress : MonoBehaviour , IPointerDownHandler, IPointerUpHandler {

	[SerializeField] private float jumpPower = 2.288f;

	bool pressed = false;
	public Rigidbody2D rb;


	public void OnPointerDown(PointerEventData eventData){

		pressed = true;
	}

	public void OnPointerUp(PointerEventData eventData){

		pressed = false;

	}


	void Update () {


		if(pressed)
		{
			hmmmm ();

		}


	}

	public void hmmmm(){

		rb.AddForce(new Vector2(0, jumpPower) , ForceMode2D.Impulse);
		pressed = false;
	}
}
