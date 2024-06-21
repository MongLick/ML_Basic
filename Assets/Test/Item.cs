using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
	private void OnCollisionEnter(Collision collision) // 물리적 반발력 있을 때
	{
		if(collision.gameObject.tag == "Player")
		{
			Destroy(gameObject);
		}
	}

	private void OnTriggerEnter(Collider other) // 물리적 반발력 없고 싶을 때
	{
		if (other.gameObject.tag == "Player")
		{
			Destroy(gameObject);
		}
	}
}
