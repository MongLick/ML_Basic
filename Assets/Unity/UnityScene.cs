using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.SceneManagement;
using AsyncOperation = UnityEngine.AsyncOperation;

public class UnityScene : MonoBehaviour
{
    // 씬(Scene)
    // 유니티에서 게임월드를 구성하는 단위
    // 프로젝트에 원하는 수 만큼 씬을 포함할 수 있음
    // 단일 씬에서 간단한 게임을 빌드할 수도 있으며, 여러 씬을 전환하며 게임을 진행할 수 있음
    // 다중 씬을 이용하여 여러씬을 동시에 열어 같은 게임월드에서 사용도 가능함

    // <빌드 설정>
    // 씬에 대한 스크립팅 전, 게임 빌드 설정에서 씬을 포함시켜야 해당 씬을 사용 가능

    // <씬 로드>
    public void ChangeSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    public void ChangeSceneByIndex(int sceneIndex)
    {
		// 이건 로드하는 씬 하나만 부르고 나머지는 다 꺼짐
		SceneManager.LoadScene(sceneIndex, LoadSceneMode.Single); 
                                                                  
    }

    public void AddSceneByName(string sceneName)
	{
		SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
	}

	public void AddSceneByName(int sceneIndex)
    {
		// 파일에 빌드에 씬에 0번 부터 시작인데 0번은 Title씬이 국룰이다.
		SceneManager.LoadScene(sceneIndex, LoadSceneMode.Additive);
	}

    // <비동시 씬 로드> 제일 많이 사용함 씬 매니저 만들 때 배울 내용
    public void ChangeSceneASyne(string sceneName)
    {
		// 비동기 씬 로드 : 백그라운드로 씬을 로딩하도록 하여 게임 중 멈춤이 없도록 함
		AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneName);


		asyncOperation.allowSceneActivation = true; // 씬 로딩 완료시 반로 씬 로드를 진행하는지 여부
        bool isLoad = asyncOperation.isDone; // 씬 로딩이 완료되었는지 판단
        float progress = asyncOperation.progress; // 씬 로딩을 확인
        asyncOperation.completed += (oper) => { }; // 씬 로딩 완료시 진행할 이벤트 추가
    }
}
