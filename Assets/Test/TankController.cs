using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankController : MonoBehaviour, IDamageble
{
	Vector3 moveDir;

	[SerializeField] float moveSpeed;
	[SerializeField] float rotateSpeed;

	private void OnMove(InputValue value)
	{
		Vector2 inputDir = value.Get<Vector2>();

		moveDir.x = inputDir.x;
		moveDir.z = inputDir.y;
	}

	private void OnRotate(InputValue value)
	{
		Vector2 inputDir = value.Get<Vector2>();

		moveDir.x = inputDir.x;
		moveDir.z = inputDir.y; // x, z가 둘다 있어야한다. 없으면 안 돌아감.
	}

	private void Move()
	{
		transform.Translate(0, 0, moveDir.z * moveSpeed * Time.deltaTime, Space.Self);
	}

	private void Rotate()
	{
		transform.Rotate(Vector3.up, moveDir.x * rotateSpeed * Time.deltaTime, Space.Self);
	}

	private void Update()
	{
		Move();
		Rotate();
	}
}
