using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
	public void NextScene()
	{
		SceneManager.LoadScene("level1");
	}
}