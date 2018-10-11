using UnityEngine;
using UnityEngine.SceneManagement;

public class slowdown : MonoBehaviour
{
	public void NextScene()
	{
		SceneManager.LoadScene("Slow");
	}
}