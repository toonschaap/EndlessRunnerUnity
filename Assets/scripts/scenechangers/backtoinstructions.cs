using UnityEngine;
using UnityEngine.SceneManagement;

public class backtoinstructions : MonoBehaviour
{
	public void NextScene()
	{
		SceneManager.LoadScene("instructions");
	}
}
