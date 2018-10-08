using UnityEngine;
using UnityEngine.SceneManagement;

public class aliens : MonoBehaviour
{
	public void NextScene()
	{
		SceneManager.LoadScene("aliens");
	}
}