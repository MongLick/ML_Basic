using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class UnityScript : MonoBehaviour
{
	/**********************************************************
    * ������Ʈ (Component)
    * 
    * Ư���� ����� ������ �� �ֵ��� ������ ���� ����� ����
    * ���ӿ�����Ʈ�� �۵��� ������ ��ǰ
    * ���ӿ�����Ʈ�� �߰�, �����ϴ� ����� ������ ��ǰ
    **********************************************************/

	/********************************************************************************
	 * MonoBehaviour
	 * 
	 * ������Ʈ�� �⺻Ŭ������ �ϴ� Ŭ������ ����Ƽ ��ũ��Ʈ�� �Ļ��Ǵ� �⺻ Ŭ����
	 * ���ӿ�����Ʈ�� ��ũ��Ʈ�� ������Ʈ�μ� ������ �� �ִ� ������ ����
	 * ��ũ��Ʈ ����ȭ ���, ����Ƽ �޽��� �Լ� ���, �ڷ�ƾ ����� ������
	 ********************************************************************************/

	/*********************************************************************
    * ����ȭ(Serialization)
    * 
    * ������ ���� �Ǵ� ���ӿ�����Ʈ ���¸� �����ϰ� �����ϴ� ���
    * �ν����� â���� ������Ʈ�� ����ȭ�� ������� ���� ������
	* �̸� �̿��Ͽ� �ҽ��ڵ��� ���� ���� ����Ƽ �����Ϳ��� ���� ���� ����
	**********************************************************************/

	// <������ ����ȭ>
	// ������Ʈ�� ������� ���� Ȯ���ϰų� ����
	// ������Ʈ�� ������� ������ �巡�� �� ��� ������� ����

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

	// ������
	public ForceMode mode;

	// ����ȭ ������ �ʵ��� �迭 �� List<T>
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

	// <��Ʈ����Ʈ>
	// Ŭ����, �Ӽ� �Ǵ� �Լ� ���� ����Ͽ� Ư���� ������ ��Ÿ�� �� �ִ� ��Ŀ
	
	[Space(30)] // 30�ȼ� ���� ������

	[Header("Unity Attribute")] // ��� ���� �������� �ν�����â�� ������ ĭ ����? ����

	[SerializeField] // private ���������� �ν�����â���� ���δ�.
	private int privateValue;

	[HideInInspector] // public ���������� �ν�����â���� ������ �ʴ´�.
	public int publicValue;

	[Range(0, 10)] // �ۼ�Ʈ �� 0~10������ �� �� �ִ�. �ּ� �ִ븦 �����ش�.
	public float rangeValue;

	[TextArea(3, 5)] // �幮�� �ؽ����� �� �� ����. �ּ� 3�� �ִ� 5�� �̶�� ��
	public string textField;

	[Serializable] // ����ü�� ����ȭ ���� �Ӽ��� ����
	public struct StructType
	{
		public int value1;
		public string value2;
	}
	public StructType structField;

	[Serializable] // Ŭ������ ����ȭ ���� �Ӽ��� ����
	public class ClassType
	{
		public int value1;
		public string value2;
	}
	public ClassType classField;
}
