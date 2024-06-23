// ������ ���� �̱���(Singleton)

// <�̱��� ����>
// ���� �Ѱ��� Ŭ���� �ν��Ͻ����� ������ ����
// �̿� ���� �������� �������� ����

// ����
// �������� ���ٱ����� �ܺο��� ������ �� ������ ����
// ���������� Ȱ���Ͽ� ĸ��ȭ�� ����
// �������� ���� ������ �ν��Ͻ��� ���� ���� ���������� ���
// GetInstance �Լ��� ���ؼ� ���� ��ü�� ���� ��� ����
// ���ϰ�ü�� �ִ� ���� ���ϰ�ü�� ��ȯ�� �ֵ��� ����

// ����
// �ϳ����� ����� �ֿ� Ŭ����, �������� ������ ��
// ������ �������� ������ �ʿ��� �۾��� ���� �������ٰ���
// �ν��Ͻ����� �̱����� ���Ͽ� �����͸� �����ϱ� ������

// ����
// �̱����� �ʹ� ���� å���� �������� ��츦 �����ؾ���
// �̱����� ���߷� ���������� �������� �Ǵ� ���, ������ �ڵ��� ���յ��� ������
// �̱����� �����͸� ������ ��� ������ ������ �����ؾ���

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
		// �̷��� �ϸ� 123 ���δ� �Ȱ��� �ν��Ͻ��� ����Ű�� ���̴�.
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
