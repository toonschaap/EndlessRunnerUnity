using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{

    
    private Vector3 playerStartPoint;

    public Transform platformGenerator;
    private Vector3 platformStartPoint;

    private PlatformDestroyer[] platforms;

    

	void Start ()
    {
        
        platformStartPoint = platformGenerator.position;
	}

   
    public void Reset()
    {
        
        platforms = FindObjectsOfType<PlatformDestroyer>();
        for (var i = 0; i < platforms.Length; i++)
        {
            platforms[i].gameObject.SetActive(false);
        }

        platformGenerator.position = platformStartPoint;

    
        
    }
}
