using UnityEngine;
using UnityEngine.SceneManagement;

public class wall : MonoBehaviour
{
	public void NextScene()
	{
		SceneManager.LoadScene("wall");
	}
}
