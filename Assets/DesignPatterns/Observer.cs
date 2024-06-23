using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

// ������ ���� ������(Observer)

// <������ ����>
// �������� ��ü�� ���� ��ȭ�� �����ϴ� ������
// �������ü�� ���������� ����� ����Ͽ� ����
// �������ü�� ���� ��ȭ�� ���� �� ���� ����� �������鿡�� �˸�

// ����
// c#�� ��� event delegate�� �̿��Ͽ� ������ ������ ���밡��
// Unity�� ��� UnityEvent�� �̿��Ͽ� ������ ������ ���밡��

// ����
// Ŭ�������� ������ ���ᱸ���� ������ ��ü���� �ý����� ����
// ��������Ģ�� �ؼ��ϰ� ��
// �����Ӹ��� ���� ��ȭ�� Ȯ���ϴ� ������� ���귮�� ���� �� ����

// ����
// ������ ������ �� ����
// �������� ����� �̺�Ʈ ����, ��ȯ ���� ���� ������ �߻��� �� ����



// �ҽ��� ¥�� �̷��� ¥�µ� ����Ƽ���� �巡�׾� ����ϴ� ���� ����.
// �̹� C# Unity�� �����Ǿ� �ֱ� ������ ���� ������ ������ ������ ���� ����
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
