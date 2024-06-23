using UnityEngine;
using UnityEngine.InputSystem;

public class TestMove : MonoBehaviour
{
	public Rigidbody rigid;
	public float moveSpeed;

	private Vector2 moveInput;

	private void OnMove1(InputValue value)
	{
		moveInput = value.Get<Vector2>();
	}

	private void FixedUpdate()
	{
		Move();
	}

	private void Move()
	{
		// �÷��̾��� ���� ���͸� �������� ������ ���
		Vector3 forwardDir = transform.forward * moveInput.y;
		Vector3 rightDir = transform.right * moveInput.x;

		// ������ ������ �ջ��Ͽ� ���� ���մϴ�
		Vector3 movement = (forwardDir + rightDir).normalized * moveSpeed;
		rigid.AddForce(movement, ForceMode.Force);
	}
}