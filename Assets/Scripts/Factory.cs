using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{

    [SerializeField] GameObject prefab;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            GameObject go = Instantiate(prefab, transform);
            Destroy(go, 3); // Second parameter is in seconds.
        }
    }
}
