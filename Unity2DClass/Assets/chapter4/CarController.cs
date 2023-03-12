using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CarController : MonoBehaviour
{
	CarGameManager carGameManager;
	
	public float speed = 0;
	public float Length;
	public bool Judgement = true;
	public int count = 0;
	GameObject distanceText;
	Vector2 startPos;
	void Start()
	{
		distanceText = GameObject.Find("Distance");
	}

	// Update is called once per frame
	void Update()
	{
		if (Judgement)
		{
			if (speed < 0.01f)
			{
				if (Input.GetMouseButtonDown(0))
				{
					startPos = Input.mousePosition;
				}
				else if (Input.GetMouseButtonUp(0))
				{
					Vector2 endPos = Input.mousePosition;
					Length = endPos.x - startPos.x;

					speed = Length / 1000.0f;
					count++;
				}
			}
		}
		transform.Translate(speed, 0, 0);
		speed *= 0.95f;
	}
}
