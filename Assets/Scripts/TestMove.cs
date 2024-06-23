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
		// 플레이어의 방향 벡터를 기준으로 움직임 계산
		Vector3 forwardDir = transform.forward * moveInput.y;
		Vector3 rightDir = transform.right * moveInput.x;

		// 움직임 방향을 합산하여 힘을 가합니다
		Vector3 movement = (forwardDir + rightDir).normalized * moveSpeed;
		rigid.AddForce(movement, ForceMode.Force);
	}
}