// 디자인 패턴 싱글톤(Singleton)

// <싱글톤 패턴>
// 오직 한개의 클래스 인스턴스만을 갖도록 변경
// 이에 대한 전역적인 접근점을 제공

// 구현
// 생성자의 접근권한을 외부에서 생성할 수 없도록 제한
// 정적변수를 활용하여 캡슐화를 진행
// 전역에서 접근 가능한 인스턴스를 갖기 위해 정적변수를 사용
// GetInstance 함수를 통해서 단일 객체가 없는 경우 생성
// 단일객체가 있는 경우는 단일객체를 반환해 주도록 구현

// 장점
// 하나뿐인 존재로 주요 클래스, 관리자의 역할을 함
// 전역적 접근으로 참조에 필요한 작업이 없이 빠른접근가능
// 인스턴스들이 싱글톤을 통하여 데이터를 공유하기 쉬워짐

// 단점
// 싱글톤이 너무 많은 책임을 짊어지는 경우를 주의해야함
// 싱글톤이 남발로 전역접근이 많아지게 되는 경우, 참조한 코드의 결합도가 높이짐
// 싱글톤의 데이터를 공유할 경우 데이터 변조에 주의해야함

public class Singleton
{
	private static Singleton instance;

	private Singleton() { }

	public static Singleton GetInstance()
	{
		if (instance == null)
		{
			instance = new Singleton();
		}

		return instance;
	}

	public int gold = 0;
}

public class OtherClass1
{
	public void Funcion()
	{
		Singleton instance1 = Singleton.GetInstance();
		Singleton instance2 = Singleton.GetInstance();
		Singleton instance3 = Singleton.GetInstance();
		// 이렇게 하면 123 전부다 똑같은 인스턴스를 가르키는 것이다.
	}
}

public class Player1
{
	public void SpendGold()
	{
		Singleton.GetInstance().gold -= 100;
	}
}

public class Monster1
{
	public void Die()
	{
		Singleton.GetInstance().gold += 100;
	}
}

public class Item1
{
	public void GetGold()
	{
		Singleton.GetInstance().gold += 100;
	}
}
