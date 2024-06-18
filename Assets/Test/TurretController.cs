using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TurretController : MonoBehaviour
{
	Vector3 moveDir;
	[SerializeField] float rotateSpeed;

	private void OnRotate(InputValue value)
	{
		Vector2 inputDir = value.Get<Vector2>();

		moveDir.x = inputDir.x;
		moveDir.z = inputDir.y;
	}

	private void Rotate()
	{
		transform.Rotate(Vector3.up, moveDir.x * rotateSpeed * Time.deltaTime, Space.World); // 좌우 위에서 축을 꽂았다고 생각
		transform.Rotate(Vector3.right, moveDir.z * rotateSpeed * Time.deltaTime, Space.Self); // 위아래 옆에서 축을 꽂았다고 생각
	}

	private void Update()
	{
		Rotate();
	}
}
