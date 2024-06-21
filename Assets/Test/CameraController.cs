using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform follow;

    public Vector3 offset;

	private void LateUpdate()
	{
		// 카메라는 무조건 LatrUpdate에서 한다고 생각
		// 절대 Update에서 돌리면 안됨. 와들 와들 떨림
		transform.position = follow.position + offset;
		transform.LookAt(follow.position);
	}
}
