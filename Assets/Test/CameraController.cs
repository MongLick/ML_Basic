using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform follow;

    public Vector3 offset;

	private void LateUpdate()
	{
		// ī�޶�� ������ LatrUpdate���� �Ѵٰ� ����
		// ���� Update���� ������ �ȵ�. �͵� �͵� ����
		transform.position = follow.position + offset;
		transform.LookAt(follow.position);
	}
}
