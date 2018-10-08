using UnityEngine;
using UnityEngine.SceneManagement;

public class gotoupperwall : MonoBehaviour
{
	public void NextScene()
	{
		SceneManager.LoadScene("upperwall");
	}
}
