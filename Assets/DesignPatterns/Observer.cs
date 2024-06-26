using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

// 디자인 패턴 옵저버(Observer)

// <옵저버 패턴>
// 옵저버는 객체의 상태 변화를 관찰하는 관찰자
// 관찰대상개체는 옵저버들의 목록을 등록하여 보관
// 관찰대상객체에 상태 변화가 있을 때 마다 등록한 옵저버들에게 알림

// 구현
// c#의 경우 event delegate를 이용하여 옵저버 패턴을 적용가능
// Unity의 경우 UnityEvent를 이용하여 옵저버 패턴을 적용가능

// 장점
// 클래스간의 느슨한 연결구조로 유연한 객체지향 시스템을 구축
// 개방폐쇄원칙을 준수하게 됨
// 프레임마다 상태 변화를 확인하는 방법보다 연산량이 줄일 수 있음

// 단점
// 순서를 보장할 수 없음
// 부주의한 사용은 이벤트 연쇄, 순환 구조 등의 문제가 발생할 수 있음



// 소스로 짜면 이렇게 짜는데 유니티에서 드래그앤 드롭하는 것이 낫다.
// 이미 C# Unity에 구현되어 있기 때문에 내가 옵저버 패턴을 구현할 일은 없음
public class Observer 
{
	public void Notify()
	{

	}
}

public class Subject
{
	private List<Observer> observerList;

	public void RegisterObserver(Observer observer)
	{ 
		observerList.Add(observer);
	}

	public void UnregisterObserver(Observer observer)
	{
		observerList.Remove(observer);
	}

	public void NotifyObserver()
	{
		foreach(Observer observer in observerList)
		{
			observer.Notify();
		}
	}
}
