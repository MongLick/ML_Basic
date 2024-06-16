using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class UnityScript : MonoBehaviour
{
	/**********************************************************
    * 컴포넌트 (Component)
    * 
    * 특정한 기능을 수행할 수 있도록 구성한 작은 기능적 단위
    * 게임오브젝트의 작동과 관련한 부품
    * 게임오브젝트에 추가, 삭제하는 방식의 조립형 부품
    **********************************************************/

	/********************************************************************************
	 * MonoBehaviour
	 * 
	 * 컴포넌트가 기본클래스로 하는 클래스로 유니티 스크립트가 파생되는 기본 클래스
	 * 게임오브젝트에 스크립트를 컴포넌트로서 연결할 수 있는 구성을 제공
	 * 스크립트 직렬화 기능, 유니티 메시지 함수 기능, 코루틴 기능을 포함함
	 ********************************************************************************/

	/*********************************************************************
    * 직렬화(Serialization)
    * 
    * 데이터 구조 또는 게임오브젝트 상태를 보관하고 관리하는 기법
    * 인스펙터 창에서 오브젝트의 직렬화된 멤버변수 값을 보여줌
	* 이를 이용하여 소스코드의 수정 없이 유니티 에디터에서 값을 변경 가능
	**********************************************************************/

	// <데이터 직렬화>
	// 오브젝트의 멤버변수 값을 확인하거나 변경
	// 오브젝트의 멤버변수 참조를 드래그 앤 드랍 방식으로 연결

	[Header("Value")]
	// C# Type
	public bool boolValue;
	public int intValue;
	public float floatValue;
	public string stringValue;

	// Unity Type
	public Vector3 vector3;
	public Vector3Int vector3Int;
	public Vector2 vector2;
	public Vector2Int vector2Int;
	public Color color;
	public Rect rect;
	public LayerMask layerMask;
	public AnimationCurve curve;
	public Gradient gradient;

	// 열거형
	public ForceMode mode;

	// 직렬화 가능한 필드의 배열 및 List<T>
	public int[] array;
	public List<int> list;

	[Header("Unity Reference")]
	// Object Type
	public new GameObject gameObject;
	public new Transform transform;
	public new Rigidbody rigidbody;
	public new Collider collider;

	[Header("Unity Event")]
	public UnityEvent<int> OnPlayerDamaged;

	public void Tset()
	{
		OnPlayerDamaged.Invoke(1);
	}

	// <어트리뷰트>
	// 클래스, 속성 또는 함수 위에 명시하여 특별한 동작을 나타낼 수 있는 마커
	
	[Space(30)] // 30픽셀 간격 벌리기

	[Header("Unity Attribute")] // 헤더 찐한 색상으로 인스펙터창에 보여줌 칸 띄우기? 느낌

	[SerializeField] // private 변수이지만 인스펙터창에서 보인다.
	private int privateValue;

	[HideInInspector] // public 변수이지만 인스펙터창에서 보이지 않는다.
	public int publicValue;

	[Range(0, 10)] // 퍼센트 등 0~10까지만 쓸 수 있다. 최소 최대를 정해준다.
	public float rangeValue;

	[TextArea(3, 5)] // 장문의 텍스차가 될 것 같다. 최소 3줄 최대 5줄 이라는 뜻
	public string textField;

	[Serializable] // 구조체에 직렬화 가능 속성을 포함
	public struct StructType
	{
		public int value1;
		public string value2;
	}
	public StructType structField;

	[Serializable] // 클래스에 직렬화 가능 속성을 포함
	public class ClassType
	{
		public int value1;
		public string value2;
	}
	public ClassType classField;
}
