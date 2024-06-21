using UnityEngine;

public class UnityCollision : MonoBehaviour
{
	// �浹ü
	// ������ �浹�� ���� ���ӿ�����Ʈ�� ����� ����
	// ���ӿ�����Ʈ�� ǥ���� �޽ÿ� �Ȱ��� �ʿ�� ����
	// �浹ü�� �浹��Ȳ�� ���� ��� ����Ƽ �浹 �޽����� �޾� ��Ȳ�� Ȯ��
	// �� �����ſ� �浹�� �� ��

	private void OnCollisionEnter(Collision collision)
	{
		// �浹�� �������� ��
	}

	private void OnCollisionStay(Collision collision)
	{
		// �浹���� ��
	}

	private void OnCollisionExit(Collision collision)
	{
		// �浹�� Ż������ ��
	}

	// Ʈ���� �浹ü
	// �ϳ��� �浹ü�� �浹�� ����Ű�� �ʰ� �ٸ� �浹ü�� ������ ���� ���� ����
	// Ʈ���Ű� ��ħ��Ȳ�� ���� ��� ����Ƽ Ʈ���� �޽����� �޾� ��Ȳ�� Ȯ��
	// ��ħ ���θ� Ȯ��.
	// �� ���� ������ �� ���� �� ������ ���� ��

	private void OnTriggerEnter(Collider other)
	{
		
	}

	private void OnTriggerStay(Collider other)
	{
		
	}

	private void OnTriggerExit(Collider other)
	{
		
	}

	// <���̾��� �浹 ����>
	// ���ӿ�����Ʈ�� ���̾ Ȱ���Ͽ� �浹ü���� �浹���� ���θ� ���� ����
	// edit -> ProjectSettings -> Physice���� ���� ����

	// <�浹ü ����>
	// (1) ���� �浹ü (Static Collider)
	// Rigidbody�� ���� �浹ü, �ܺο� ���� �������� ����
	// ����� �������� �ʴ� ����, ������ҿ� �ַ� ���
	// ������ ������ ������ ���ʿ� �浹 ������ ������� �ʴ´�.
	
	// (2) ������ٵ� �浹ü (Rigidbody Collider)
	// Rigidbody�� �ִ� �浹ü, �ͺο� ���� �޾� ������
	// �浹�� �� ������ ������ ����ϴ� ���� �� ���� ���� ���Ǵ� �浹ü�� ���
	
	// (3) Ű�׸�ƽ �浹ü(Kinematic Collider)
	// ���������� �ܺ� ��ݿ��� �и��� �ʴ� ��ü(�о�� ��ֹ�, �̴��̹� ��)� ���
	// kinematic ���¸� Ȱ��ȭ/��Ȱ��ȭ �Ͽ� ������ ���θ� ������ ��� ����Ѵ�.

	// <�浹ü ��ȣ�ۿ� ��Ʈ����>
	// ���ǻ� �����浹ü(SC), ������ٵ��浹ü(RC), Ű�׸�ƽ�浹ü(KC)�� ǥ��
	// ���ǻ� ����Ʈ����(ST), ������ٵ�Ʈ����(RT), Ű�޳�ƽƮ����(KT)�� ǥ��

	// �浹�� �浹 �޽����� ����
	//       SC  RC  KC
	// SC	     0
	// RC     0  0   0
	// KC        0

	// �浹�� Ʈ���� �޽����� ����
	//       SC  RC  KC  ST  RT  KT
	// SC                    0   0
	// RC                0   0   0
	// KC                0   0   0
	// ST        0   0       0   0
	// RT    0   0   0   0   0   0
	// KT    0   0   0   0   0   0
}
