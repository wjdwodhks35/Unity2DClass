using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
	float rotSpeed = 0; //ȸ�� �ӵ�
	int a = 1;

	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButton(0)) //���콺 ��Ŭ��
		{
			rotSpeed = 10.0f;
			Debug.Log($"����ӵ� : {rotSpeed}");
		}

		//ȸ���ӵ���ŭ �귿�� ȸ���Ѵ�.
		transform.Rotate(0, 0, rotSpeed);

		rotSpeed *= 0.995f;

		if (rotSpeed < 0.01f && rotSpeed != 0)
		{

			// Debug.Log($"{transform.rotation.eulerAngles.z}");

			if (transform.rotation.eulerAngles.z % 360 + 30 <= 60)
				Debug.Log("��� ����");
			else if (transform.rotation.eulerAngles.z % 360 + 30 <= 120)
				Debug.Log("��� ����");
			else if (transform.rotation.eulerAngles.z % 360 + 30 <= 180)
				Debug.Log("��� �ſ� ����");
			else if (transform.rotation.eulerAngles.z % 360 + 30 <= 240)
				Debug.Log("��� ����");
			else if (transform.rotation.eulerAngles.z % 360 + 30 <= 300)
				Debug.Log("��� ����");
			else
				Debug.Log("��� ����");

			rotSpeed = 0;
		}
	}
}
