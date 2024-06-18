using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityTransform : MonoBehaviour
{
	/****************************************************************************************
	* Ʈ������ (Transform)
	* 
	* ���ӿ�����Ʈ�� ��ġ, ȸ��, ũ�⸦ �����ϴ� ������Ʈ
	* ���ӿ�����Ʈ�� �θ�-�ڽ� ���¸� �����ϴ� ������Ʈ
	* ���ӿ�����Ʈ�� �ݵ�� �ϳ��� Ʈ������ ������Ʈ�� ������ ������ �߰� & ������ �� ����
	****************************************************************************************/

	[SerializeField] Transform thisTransform;
	[SerializeField] Transform otherTransform;

	float moveSpeed = 3f;
	float rotateSpeed = 90f;

	// <Ʈ������ ����>
	// transform : ���ӿ�����Ʈ�� �ִ� Transform ������Ʈ�� ����
	private void TransformReference()
	{
		thisTransform = transform;
	}

	// <Ʈ������ �̵�>
	// Translate : Ʈ������ �̵� �Լ�
	private void Translate()
	{
		// ���͸� �̿��� �̵�
		transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

		// x, y, z�� �̿��� �̵�
		transform.Translate(0, 0, moveSpeed * Time.deltaTime);

		// position�� �̿��� �̵�
		transform.position += new Vector3(0, 0, moveSpeed * Time.deltaTime);
	}


	// <Ʈ������ �̵� ����>
	// Ʈ������ �̵��� ������ ����
	private void TranslateSpace()
	{
		// ���带 �������� �̵�
		transform.Translate(0, 0, 1, Space.World);
		// ������ �������� �̵�
		transform.Translate(0, 0, 1, Space.Self);
		// �ٸ� ����� �������� �̵�
		transform.Translate(0, 0, 1, otherTransform);
	}


	// <Ʈ������ ȸ��>
	// Rotate : Ʈ������ ȸ�� �Լ�
	private void Rotate()
	{
		// ���� �̿��� ȸ�� (���� �������� �ð�������� ȸ��)
		transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
		// ���Ϸ��� �̿��� ȸ��
		transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
		// rotation�� �̿��� ȸ��
		transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
	}


	// <Ʈ������ ȸ�� ����>
	// Ʈ������ ȸ���� ������ ����
	private void RotateSpace()
	{
		// ���带 �������� ȸ��
		transform.Rotate(0, 0, 1, Space.World);
		// ������ �������� ȸ��
		transform.Rotate(0, 0, 1, Space.Self);
		// ��ġ�� �������� ȸ��
		transform.RotateAround(otherTransform.position, Vector3.up, 1);
	}


	// <Ʈ������ LookAt ȸ��>
	// LookAt : ��ġ�� �ٶ󺸴� �������� ȸ��
	private void LookAt()
	{
		// ��ġ�� �ٶ󺸴� ȸ��
		transform.LookAt(otherTransform.position);
	}
}
