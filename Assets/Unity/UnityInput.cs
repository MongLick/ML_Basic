using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class UnityInput : MonoBehaviour
{
	/***************************************************************************
    * ����Ƽ �Է�
    * 
    * ����Ƽ���� ������� ������ ������ �� �ִ� ����
    * ����ڴ� �ܺ� ��ġ�� �̿��Ͽ� ������ ������ �� ����
    * ����Ƽ�� �پ��� Ÿ���� �Է±��(Ű���� �� ���콺, ���̽�ƽ, ��)�� ����)
    ***************************************************************************/

	// <Device>
	// Ư���� ��ġ�� �������� �Է� ����
	// Ư���� ��ġ�� �Է��� �����ϱ� ������ ���� �÷����� ������ �����
	private void InputByDevice()
	{
		// Ű���� �Է°���
		if (Input.GetKey(KeyCode.Space)) // ������ �ִ� ��
		{
			Debug.Log("Space key is perssing");
		}
		if (Input.GetKeyDown(KeyCode.Space)) // ������ ���� ��
		{
			Debug.Log("Space key is down");
		}
		if (Input.GetKeyUp(KeyCode.Space)) // ���� ��
		{
			Debug.Log("Space key is up");
		}

		// ���콺 �Է°���
		if (Input.GetMouseButton(0))
		{
			Debug.Log("Mouse left button is pressing");
		}
		if (Input.GetMouseButtonDown(0))
		{
			Debug.Log("Mouse left button is down");
		}
		if (Input.GetMouseButtonUp(0))
		{
			Debug.Log("Mouse left button is up");
		}
	}


	// <InputManager>
	// ���� ��ġ�� �Է��� �Է¸Ŵ����� �̸��� �Է��� ����
	// �Է¸Ŵ����� �̸����� ������ �Է��� ��������� Ȯ��
	// ����Ƽ �������� Edit -> Project Settings -> Input Manager ���� ����
	// ��, ����Ƽ ��â���� ����̱� ������ Ű����, ���콺, ���̽�ƽ�� ���� ��ġ���� ������
	private void InputByInputManager()
	{
		// ��ư �Է�
		// Fire1 : Ű����(Left ctrl), ���콺(Left button), ���̽�ƽ(Button0)���� ������
		if (Input.GetButton("Fire1"))
		{
			Debug.Log("Fire1 is pressing");
		}
		if (Input.GetButtonDown("Fire1"))
		{
			Debug.Log("Fire1 is down");
		}
		if (Input.GetButtonUp("Fire1"))
		{
			Debug.Log("Fire1 is up");
		}

		// �� �Է�
		// Horizontal(����) : Ű����(a,d / ��,��), ���̽�ƽ(���� �Ƴ��α׽�ƽ �¿�)
		float x = Input.GetAxis("Horizontal");
		if (x != 0)
		{
			Debug.Log($"Horizontal Axis {x}");
		}
		// Vertical(����) : Ű����(w,s / ��,��), ���̽�ƽ(���� �Ƴ��α׽�ƽ ����)
		float y = Input.GetAxis("Vertical");
		if (y != 0)
		{
			Debug.Log($"Vertical Axis {y}");
		}
	}

	// <InputSystem>
	// InputSystem ��Ű���� �̿��� �Է¹��
	// ������Ʈ�� ���� �Է��� ��������� Ȯ��
	// �ֽſ� ������ ������� �پ��� ��⸦ ����

	Vector3 moveDir;

	private void OnMove(InputValue value)
	{
		// Move �� �Է¿� �����ϴ� OnMove �޽��� �Լ�
		Vector2 inputDir = value.Get<Vector2>();

		moveDir.x = inputDir.x;
		moveDir.z = inputDir.y;
	}

	[SerializeField] Rigidbody rigid;

	private void OnJump(InputValue value)
	{
		bool inputButton = value.isPressed;
		Jump();
	}

	private void Move()
	{
		transform.position += moveDir * 3f * Time.deltaTime;
	}

	private void Jump()
	{
		rigid.AddForce(Vector3.up * 5f, ForceMode.Impulse);
	}

	private void Update()
	{
		Move();
	}
}