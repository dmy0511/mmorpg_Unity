using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabTest : MonoBehaviour
{
    GameObject prefab;

    private GameObject tank;
    
    void Start()
    {
        prefab = Resources.Load<GameObject>("Prefabs/Tank");
        tank = Instantiate(prefab);

        Destroy(tank, 3.0f);
    }
}
