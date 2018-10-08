using UnityEngine;
using UnityEngine.SceneManagement;

public class backtotitle : MonoBehaviour
{
	public void NextScene()
	{
		SceneManager.LoadScene("start");
	}
}