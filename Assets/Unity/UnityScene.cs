using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.SceneManagement;
using AsyncOperation = UnityEngine.AsyncOperation;

public class UnityScene : MonoBehaviour
{
    // ��(Scene)
    // ����Ƽ���� ���ӿ��带 �����ϴ� ����
    // ������Ʈ�� ���ϴ� �� ��ŭ ���� ������ �� ����
    // ���� ������ ������ ������ ������ ���� ������, ���� ���� ��ȯ�ϸ� ������ ������ �� ����
    // ���� ���� �̿��Ͽ� �������� ���ÿ� ���� ���� ���ӿ��忡�� ��뵵 ������

    // <���� ����>
    // ���� ���� ��ũ���� ��, ���� ���� �������� ���� ���Խ��Ѿ� �ش� ���� ��� ����

    // <�� �ε�>
    public void ChangeSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    public void ChangeSceneByIndex(int sceneIndex)
    {
		// �̰� �ε��ϴ� �� �ϳ��� �θ��� �������� �� ����
		SceneManager.LoadScene(sceneIndex, LoadSceneMode.Single); 
                                                                  
    }

    public void AddSceneByName(string sceneName)
	{
		SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
	}

	public void AddSceneByName(int sceneIndex)
    {
		// ���Ͽ� ���忡 ���� 0�� ���� �����ε� 0���� Title���� �����̴�.
		SceneManager.LoadScene(sceneIndex, LoadSceneMode.Additive);
	}

    // <�񵿽� �� �ε�> ���� ���� ����� �� �Ŵ��� ���� �� ��� ����
    public void ChangeSceneASyne(string sceneName)
    {
		// �񵿱� �� �ε� : ��׶���� ���� �ε��ϵ��� �Ͽ� ���� �� ������ ������ ��
		AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneName);


		asyncOperation.allowSceneActivation = true; // �� �ε� �Ϸ�� �ݷ� �� �ε带 �����ϴ��� ����
        bool isLoad = asyncOperation.isDone; // �� �ε��� �Ϸ�Ǿ����� �Ǵ�
        float progress = asyncOperation.progress; // �� �ε��� Ȯ��
        asyncOperation.completed += (oper) => { }; // �� �ε� �Ϸ�� ������ �̺�Ʈ �߰�
    }
}
