using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Managers : MonoBehaviour
{
    static Managers Instance;

    public static Managers GetInstance()
    {
        Init();
        return Instance;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    public static void Init()
    {
        if (Instance == null)
        {
            GameObject go = GameObject.Find("Managers");
            if (go == null)
            {
                go = new GameObject() { name = "Managers" };
                go.AddComponent<Managers>();
            }
            DontDestroyOnLoad(go);
            Instance = go.GetComponent<Managers>();
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
