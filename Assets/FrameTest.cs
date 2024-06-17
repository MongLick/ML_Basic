using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameTest : MonoBehaviour
{
	[SerializeField] Rigidbody rigid;
	[SerializeField] Transform transform;
	[SerializeField] float moveSpeed;

	[SerializeField] float jumpCoolTime = 2f;

	private bool isJumpable = true;

	private void Update()
	{
		/*Vector3 pos = transform.position;
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			pos.x -= moveSpeed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			pos.x += moveSpeed * Time.deltaTime;
		}

		transform.position = pos;

		jumpCoolTime += Time.deltaTime;

		if (jumpCoolTime >= 2f && Input.GetKey(KeyCode.Space))
		{
			rigid.AddForce(Vector3.up * 5f, ForceMode.Impulse);
			jumpCoolTime = 0f;
		}*/

		if (isJumpable && Input.GetKeyDown(KeyCode.C))
		{
			rigid.AddForce(Vector3.up * 5f, ForceMode.Impulse);
			StartCoroutine(JumpCoolTimeRoutine());
		}
	}

	IEnumerator JumpCoolTimeRoutine()
	{
		isJumpable = false;
		Debug.Log("점프 불가능");
		yield return new WaitForSeconds(jumpCoolTime);
		Debug.Log("점프 가능");
		isJumpable = true;
	}
}
