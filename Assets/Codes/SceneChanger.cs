using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
	public Vector3 position;
	public VectorValue PlayerStorage;
	public void ChangeScene(string sceneName)
	{
		PlayerStorage.initialValue = position;
		SceneManager.LoadScene(sceneName);
	}
	public void Exit()
	{
		Application.Quit();
	}
}