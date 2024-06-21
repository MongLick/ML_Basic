using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankController : MonoBehaviour
{
	public Rigidbody rigid;
	public Transform firePoint;
	public Bullet bulletPrefab;

	public CinemachineVirtualCamera zoomCamera;

	public AudioSource shootSound;

	Vector3 moveDir;

	public float movePower;
	public float rotateSpeed;
	public float bulletForce;
	public float maxSpeed;

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
	
	private void OnZoom(InputValue value)
	{
		if(value.isPressed)
		{
			zoomCamera.Priority = 100;
		}
		else
		{
			zoomCamera.Priority = 10;
		}
	}

	private void Move()
	{
		Vector3 forceDir = transform.forward * moveDir.z;
		rigid.AddForce(forceDir * movePower, ForceMode.Force);

		if(rigid.velocity.magnitude > maxSpeed)
		{
			rigid.velocity = rigid.velocity.normalized * maxSpeed;
		}
		//transform.Translate(0, 0, moveDir.z * moveSpeed * Time.deltaTime, Space.Self);
	}

	private void Rotate()
	{
		transform.Rotate(Vector3.up, moveDir.x * rotateSpeed * Time.deltaTime, Space.Self);
	}

	private void Fire()
	{
		Bullet bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
		bullet.force = bulletForce;
		shootSound.Play();
	}

	IEnumerator Charging()
	{
		Check = true;
		yield return new WaitUntil(() => Input.GetKeyUp(KeyCode.Space));
		Fire();
		Check = false;
		bulletForce = 15;
	}

	private void Update()
	{
		Rotate();

		if(Check)
		{
			bulletForce += Time.deltaTime * 2;
			Debug.Log(bulletForce);
		}
	}

	private void FixedUpdate()
	{
		Move();
	}
}
