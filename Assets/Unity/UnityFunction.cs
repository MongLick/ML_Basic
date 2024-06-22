using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityFunction : MonoBehaviour
{
	[Header("This")]
	public GameObject thisGameObject;
	public string thisName;
	public bool thisACtive;
	public string thisTag;
	public int thisLayer;

	public new Rigidbody rigidbody; // C# ���̵� ������ �̷��� ������� ����

	[Header("GameObject")]
	public GameObject newGameObject;
	public GameObject destroyGameObject;
	public GameObject findWithName;
	public GameObject findeWithTag;

	[Header("Component")]
	public Component newComponent;
	public Component addComponent;
	public Component destroyComponet;
	public Component getComponent;
	public Component findComponent;
	public IDamageble getComponentInterface;

	private void Start()
	{
		ThisFunction();
		GameObjectFunction();
		ComponentFunction();
	}

	private void ThisFunction()
	{
		//<���� ���ӿ�����Ʈ ����>
		// ������Ʈ�� �پ��ִ� ���ӿ�����Ʈ�� Component�� ������ gameObject �Ӽ��� �̿��Ͽ� ���ٰ���
		thisGameObject = gameObject; // ������Ʈ�� �پ��ִ� ���ӿ�����Ʈ
		thisName = gameObject.name; // ���ӿ�����Ʈ�� �̸�
		thisACtive = gameObject.activeSelf; // ���ӿ�����Ʈ�� Ȱ��ȭ ���� (avtiveInHierarchy : ���Ӿ����� Ȱ��ȭ ����)
		thisTag = gameObject.tag; // ���ӿ�����Ʈ�� �±�
		thisLayer = gameObject.layer; // ���ӿ�����Ʈ�� ���̾�
	}

	private void GameObjectFunction()
	{
		// <���ӿ�����Ʈ ����>
		newGameObject = new GameObject("NewGameObject");

		// <���ӿ�����Ʈ ����>
		if(destroyGameObject != null)
		{
			Destroy(destroyGameObject, 3f); // float�� �� �� �ڿ� ����
		}

		// <���ӿ�����Ʈ Ž��>
		findWithName = GameObject.Find("Main Camera"); // �̸����� ã�� ���� ������� �ʴ� ��� �Ĵٵ� ������ �̰� �� ���� ������
		findeWithTag = GameObject.FindWithTag("MainCamera"); // �±׷� ã�� / ���� Name���� �ξ� ������. Ư���� �͸� tag�� �ޱ� ���� �� tag�� �صθ� ȿ���� �ް��Ѵ�.
		
	}

	private void ComponentFunction()
	{
		// <������Ʈ �߰�>
		// addComponent = gameObject.AddComponent<Rigidbody>(); �̰ɷ� �ϸ� �Ǵµ� �ߺ����� �������� �ϴ� �������. 
		newComponent = new Rigidbody(); // �ƿ� �� �Ǵ� ���� �ǹ̰� ����, ������Ʈ�� ���ӿ�����Ʈ�� �����Ǿ� ������ �� �ǹ̰� ����.

		// <������Ʈ ����>
		if(destroyComponet != null)
		{
			Destroy(destroyComponet, 3f); // �巡�� �� ������� �� �� ���� Add�� ���� ������Ʈ ��ü�� ���������ش�. �� �� �� ������ �����ϴ�.
		}

		// <������Ʈ Ž�� - ���ӿ�����Ʈ���� ã��> // �̰� ��뷮�� ����.
		getComponent = gameObject.GetComponent<Collider>(); // ����� ���� �����. ������ null�� ���.
		getComponentInterface = gameObject.GetComponent<IDamageble>(); // �������̽��� ã�� �� �ִ�.

		// <������Ʈ Ž�� - ������ ã��>
		findComponent = Component.FindObjectOfType<Camera>(); // �� ��ü���� ã�� �Ŷ� ���� ���� ī�޶� tag�� ã�� ���ӿ�����Ʈ�� ã�� ���� ����.
	}
}
