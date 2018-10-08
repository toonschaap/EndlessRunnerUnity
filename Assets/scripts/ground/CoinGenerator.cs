﻿using UnityEngine;
using System.Collections;

public class CoinGenerator : MonoBehaviour 
{

    public ObjectPooler coinPool;

    public float distanceBetweenCoins;
    public GameObject maxHeightPoint;
    private float maxHeight;



    void start()
    {
        maxHeight = maxHeightPoint.transform.position.y;
    }
    public void SpawnCoins(Vector3 startPosition)
    {
        startPosition.y = maxHeight;
        var coin1 = coinPool.GetPooledObject();
        
        coin1.transform.position = new Vector3(startPosition.x, startPosition.y, startPosition.z); ;
        coin1.SetActive(true);

        var coin2 = coinPool.GetPooledObject();
        coin2.transform.position = new Vector3(startPosition.x - distanceBetweenCoins, startPosition.y, startPosition.z);
        coin2.SetActive(true);

        var coin3 = coinPool.GetPooledObject();
        coin3.transform.position = new Vector3(startPosition.x + distanceBetweenCoins, startPosition.y, startPosition.z);
        coin3.SetActive(true);
    }
}
