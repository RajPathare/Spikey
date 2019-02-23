using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMove : MonoBehaviour {

	
	public Vector3 targetPosition;
    public float smoothFactor = 2;
    public Vector3 targetPosition2;
	


	// Use this for initialization
	void Start () {



	}
	
	// Update is called once per frame
	void Update () {


		var pos = new Vector3(0f,0f,0f);

		
		if(this.gameObject.activeInHierarchy){

		transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * smoothFactor);

		Invoke("goback",2);

		}
		

	
	}

	public void goback(){

		transform.position = Vector3.Lerp(transform.position, targetPosition2, Time.deltaTime * smoothFactor);
		

	}


	
}
