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

	public new Rigidbody rigidbody; // C# 하이딩 요즘은 이렇게 사용하지 않음

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
		//<현재 게임오브젝트 참조>
		// 컴포넌트가 붙어있는 게임오브젝트는 Component에 구현한 gameObject 속성을 이용하여 접근가능
		thisGameObject = gameObject; // 컴포넌트가 붙어있는 게임오브젝트
		thisName = gameObject.name; // 게임오브젝트의 이름
		thisACtive = gameObject.activeSelf; // 게임오브젝트의 활성화 여부 (avtiveInHierarchy : 게임씬에서 활성화 여부)
		thisTag = gameObject.tag; // 게임오브젝트의 태그
		thisLayer = gameObject.layer; // 게임오브젝트의 레이어
	}

	private void GameObjectFunction()
	{
		// <게임오브젝트 생성>
		newGameObject = new GameObject("NewGameObject");

		// <게임오브젝트 삭제>
		if(destroyGameObject != null)
		{
			Destroy(destroyGameObject, 3f); // float는 몇 초 뒤에 삭제
		}

		// <게임오브젝트 탐색>
		findWithName = GameObject.Find("Main Camera"); // 이름으로 찾기 별로 사용하지 않는 방법 쳐다도 보지마 이거 안 쓴다 정말로
		findeWithTag = GameObject.FindWithTag("MainCamera"); // 태그로 찾기 / 위에 Name보다 훨씬 빠르다. 특정한 것만 tag를 달기 전부 다 tag를 해두면 효율이 급감한다.
		
	}

	private void ComponentFunction()
	{
		// <컴포넌트 추가>
		// addComponent = gameObject.AddComponent<Rigidbody>(); 이걸로 하면 되는데 중복으로 오류떠서 일단 문자취급. 
		newComponent = new Rigidbody(); // 아예 안 되는 문법 의미가 없음, 컴포넌트는 게임오브젝트에 부착되어 동작할 때 의미가 있음.

		// <컴포넌트 삭제>
		if(destroyComponet != null)
		{
			Destroy(destroyComponet, 3f); // 드래그 앤 드롭으로 한 것 말고도 Add로 붙인 컴포넌트 자체를 삭제시켜준다. 몇 초 뒤 삭제도 가능하다.
		}

		// <컴포넌트 탐색 - 게임오브젝트에서 찾기> // 이게 사용량이 많다.
		getComponent = gameObject.GetComponent<Collider>(); // 상당히 많이 사용함. 없으면 null이 뜬다.
		getComponentInterface = gameObject.GetComponent<IDamageble>(); // 인터페이스도 찾을 수 있다.

		// <컴포넌트 탐색 - 씬에서 찾기>
		findComponent = Component.FindObjectOfType<Camera>(); // 씬 전체에서 찾는 거라서 많이 느림 카메라를 tag로 찾고 게임오브젝트로 찾는 것이 많다.
	}
}
