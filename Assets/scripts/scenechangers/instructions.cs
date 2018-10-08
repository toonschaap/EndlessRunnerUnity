using UnityEngine;
using UnityEngine.SceneManagement;

public class instructions : MonoBehaviour
{
	public void NextScene()
	{
		SceneManager.LoadScene("instructions");
	}
}