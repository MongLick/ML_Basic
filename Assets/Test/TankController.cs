using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankController : MonoBehaviour
{
	public Transform firePoint;
	public Bullet bulletPrefab;

	Vector3 moveDir;

	public float moveSpeed;
	public float rotateSpeed;
	public float bulletForce;

	private bool Check;

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

	private void OnFire(InputValue value)
	{
		StartCoroutine(Charging());
	}

	private void Move()
	{
		transform.Translate(0, 0, moveDir.z * moveSpeed * Time.deltaTime, Space.Self);
	}

	private void Rotate()
	{
		transform.Rotate(Vector3.up, moveDir.x * rotateSpeed * Time.deltaTime, Space.Self);
	}

	private void Fire()
	{
		Bullet bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
		bullet.force = bulletForce;
	}

	IEnumerator Charging()
	{
		Check = true;
		yield return new WaitUntil(() => Input.GetKeyUp(KeyCode.Space));
		Fire();
		Check = false;
		bulletForce = 5;
	}

	private void Update()
	{
		Move();
		Rotate();

		if(Check)
		{
			bulletForce += Time.deltaTime * 2;
			Debug.Log(bulletForce);
		}
	}
}
