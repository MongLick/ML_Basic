using UnityEngine;

public class UnityCollision : MonoBehaviour
{
	// 충돌체
	// 물리적 충돌을 위해 게임오브젝트의 모양을 정의
	// 게임오브젝트의 표현인 메시와 똑같을 필요는 없음
	// 충돌체가 충돌상황에 있을 경우 유니티 충돌 메시지를 받아 상황을 확인
	// 벽 같은거에 충돌할 때 등

	private void OnCollisionEnter(Collision collision)
	{
		// 충돌에 진입했을 때
	}

	private void OnCollisionStay(Collision collision)
	{
		// 충돌중일 때
	}

	private void OnCollisionExit(Collision collision)
	{
		// 충돌에 탈출했을 때
	}

	// 트리거 충돌체
	// 하나의 충돌체가 충돌을 일으키지 않고 다른 충돌체의 공간에 들어가는 것을 감지
	// 트리거가 겹침상황에 있을 경우 유니티 트리거 메시지를 받아 상황을 확인
	// 겹침 여부만 확인.
	// 물 같이 지나갈 수 있을 때 아이템 먹을 때

	private void OnTriggerEnter(Collider other)
	{
		
	}

	private void OnTriggerStay(Collider other)
	{
		
	}

	private void OnTriggerExit(Collider other)
	{
		
	}

	// <레이어기반 충돌 감지>
	// 게임오브젝트의 레이어를 활용하여 충돌체간의 충돌가능 여부를 설정 가능
	// edit -> ProjectSettings -> Physice에서 설정 가능

	// <충돌체 종류>
	// (1) 정적 충돌체 (Static Collider)
	// Rigidbody가 없는 충돌체, 외부에 힘에 움직이지 않음
	// 절대로 움직이지 않는 지형, 구성요소에 주로 사용
	// 정적과 정적이 만나면 애초에 충돌 연산이 진행되지 않는다.
	
	// (2) 리지드바디 충돌체 (Rigidbody Collider)
	// Rigidbody가 있는 충돌체, 와부에 힘을 받아 움직임
	// 충돌할 수 있으며 물리를 사용하는 게임 내 가장 흔히 사용되는 충돌체에 사용
	
	// (3) 키네마틱 충돌체(Kinematic Collider)
	// 움직이지만 외부 충격에는 밀리지 않는 물체(밀어내는 장애물, 미닫이문 등)등에 사용
	// kinematic 상태를 활성화/비활성화 하여 움직임 여부를 설정할 경우 사용한다.

	// <충돌체 상호작용 매트릭스>
	// 편의상 정적충돌체(SC), 리지드바디충돌체(RC), 키네마틱충돌체(KC)로 표현
	// 편의상 정적트리거(ST), 리지드바디트리거(RT), 키메나틱트리거(KT)로 표현

	// 충돌시 충돌 메시지가 전송
	//       SC  RC  KC
	// SC	     0
	// RC     0  0   0
	// KC        0

	// 충돌시 트리거 메시지가 전송
	//       SC  RC  KC  ST  RT  KT
	// SC                    0   0
	// RC                0   0   0
	// KC                0   0   0
	// ST        0   0       0   0
	// RT    0   0   0   0   0   0
	// KT    0   0   0   0   0   0
}
