using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
	public void GameStart()
	{
		SceneManager.LoadScene("GameScene");
	}
}
