using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpikeScript : MonoBehaviour {


	public GameObject leftwall1;
	public GameObject leftwall2;
	public GameObject leftwall3;
	public GameObject leftwall4;
	public GameObject leftwall5;
	public GameObject leftwall6;

	public GameObject rightwall1;
	public GameObject rightwall2;
	public GameObject rightwall3;
	public GameObject rightwall4;
	public GameObject rightwall5;

	




	int count = 0;
	int score = 0;
	public Text Score;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Score.text = score.ToString();
		
	}



	void OnCollisionEnter2D (Collision2D other)
	{

		if(other.gameObject.tag == "Lspike" || other.gameObject.tag == "Rspike")
		{

			Destroy(this.gameObject);

		}

		if(other.gameObject.tag == "rightWall" && count == 0)
		{

			
			leftwall1.SetActive(true);
			//rightWall1.SetActive(false);
			count++;
			score++;


		}

		if(other.gameObject.tag == "leftWall" && count == 1)
		{
			leftwall6.SetActive(false);
			leftwall1.SetActive(false);
			rightwall1.SetActive(true);
			count++;
			score++;

		}

		if(other.gameObject.tag == "rightWall" && count == 2)
		{

			
			leftwall2.SetActive(true);
			rightwall1.SetActive(false);
			count++;
			score++;


		}

		if(other.gameObject.tag == "leftWall" && count == 3)
		{
			
			leftwall2.SetActive(false);
			rightwall2.SetActive(true);
			count++;
			score++;

		}

		if(other.gameObject.tag == "rightWall" && count == 4)
		{

			
			leftwall3.SetActive(true);
			rightwall2.SetActive(false);
			count++;
			score++;


		}

		if(other.gameObject.tag == "leftWall" && count == 5)
		{
			
			leftwall3.SetActive(false);
			rightwall3.SetActive(true);
			count++;
			score++;

		}

		if(other.gameObject.tag == "rightWall" && count == 6)
		{

			
			leftwall4.SetActive(true);
			rightwall3.SetActive(false);
			count++;
			score++;


		}

		if(other.gameObject.tag == "leftWall" && count == 7)
		{
			
			leftwall4.SetActive(false);
			rightwall4.SetActive(true);
			count++;
			score++;


		}

		if(other.gameObject.tag == "rightWall" && count == 8)
		{

			
			leftwall5.SetActive(true);
			rightwall4.SetActive(false);
			count++;
			score++;



		}

		if(other.gameObject.tag == "leftWall" && count == 9)
		{
			
			leftwall5.SetActive(false);
			rightwall5.SetActive(true);
			count++;
			score++;

		}

		if(other.gameObject.tag == "rightWall" && count == 10)
		{

			
			leftwall6.SetActive(true);
			rightwall5.SetActive(false);
			score++;
			count = 1;

		}




	}


}
