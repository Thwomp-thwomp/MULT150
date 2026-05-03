using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Vector3 spawnPosition = transform.position + new Vector3(i * 2f, 0, 0);
            Instantiate(prefab, spawnPosition, transform.rotation);
        }
    }

    void Update()
    {

    }
}