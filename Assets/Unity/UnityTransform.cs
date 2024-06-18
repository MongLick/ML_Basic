using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityTransform : MonoBehaviour
{
	/****************************************************************************************
	* 트랜스폼 (Transform)
	* 
	* 게임오브젝트의 위치, 회전, 크기를 저장하는 컴포넌트
	* 게임오브젝트의 부모-자식 상태를 저장하는 컴포넌트
	* 게임오브젝트는 반드시 하나의 트랜스폼 컴포넌트를 가지고 있으며 추가 & 제거할 수 없음
	****************************************************************************************/

	[SerializeField] Transform thisTransform;
	[SerializeField] Transform otherTransform;

	float moveSpeed = 3f;
	float rotateSpeed = 90f;

	// <트랜스폼 접근>
	// transform : 게임오브젝트에 있는 Transform 컴포넌트에 접근
	private void TransformReference()
	{
		thisTransform = transform;
	}

	// <트랜스폼 이동>
	// Translate : 트랜스폼 이동 함수
	private void Translate()
	{
		// 벡터를 이용한 이동
		transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

		// x, y, z를 이용한 이동
		transform.Translate(0, 0, moveSpeed * Time.deltaTime);

		// position을 이용한 이동
		transform.position += new Vector3(0, 0, moveSpeed * Time.deltaTime);
	}


	// <트랜스폼 이동 공간>
	// 트랜스폼 이동의 기준을 설정
	private void TranslateSpace()
	{
		// 월드를 기준으로 이동
		transform.Translate(0, 0, 1, Space.World);
		// 로컬을 기준으로 이동
		transform.Translate(0, 0, 1, Space.Self);
		// 다른 대상을 기준으로 이동
		transform.Translate(0, 0, 1, otherTransform);
	}


	// <트랜스폼 회전>
	// Rotate : 트랜스폼 회전 함수
	private void Rotate()
	{
		// 축을 이용한 회전 (축을 기준으로 시계방향으로 회전)
		transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
		// 오일러를 이용한 회전
		transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
		// rotation을 이용한 회전
		transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
	}


	// <트랜스폼 회전 공간>
	// 트랜스폼 회전의 기준을 설정
	private void RotateSpace()
	{
		// 월드를 기준으로 회전
		transform.Rotate(0, 0, 1, Space.World);
		// 로컬을 기준으로 회전
		transform.Rotate(0, 0, 1, Space.Self);
		// 위치를 기준으로 회전
		transform.RotateAround(otherTransform.position, Vector3.up, 1);
	}


	// <트랜스폼 LookAt 회전>
	// LookAt : 위치를 바라보는 방향으로 회전
	private void LookAt()
	{
		// 위치를 바라보는 회전
		transform.LookAt(otherTransform.position);
	}
}
