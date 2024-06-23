using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private static Manager instance;
	[SerializeField] GameManager gameManager;
	[SerializeField] DataManager dataManager;

	public static Manager Inst()
	{
		return instance;
	}

	public static GameManager Game { get { return instance.gameManager; } }
	public static DataManager Data { get { return instance.dataManager; } }

	private void Awake()
	{
		if(instance != null)
		{
			Destroy(this);

			return;
		}

		instance = this;
		DontDestroyOnLoad(this);
	}

	private void OnDestroy()
	{
		if(instance == null)
		{
			instance = this;
		}
	}
}
