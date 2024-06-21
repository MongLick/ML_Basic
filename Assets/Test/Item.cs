using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
	private void OnCollisionEnter(Collision collision) // ������ �ݹ߷� ���� ��
	{
		if(collision.gameObject.tag == "Player")
		{
			Destroy(gameObject);
		}
	}

	private void OnTriggerEnter(Collider other) // ������ �ݹ߷� ���� ���� ��
	{
		if (other.gameObject.tag == "Player")
		{
			Destroy(gameObject);
		}
	}
}
