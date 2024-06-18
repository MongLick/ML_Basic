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
		transform.Rotate(Vector3.up, moveDir.x * rotateSpeed * Time.deltaTime, Space.World); // �¿� ������ ���� �ȾҴٰ� ����
		transform.Rotate(Vector3.right, moveDir.z * rotateSpeed * Time.deltaTime, Space.Self); // ���Ʒ� ������ ���� �ȾҴٰ� ����
	}

	private void Update()
	{
		Rotate();
	}
}
