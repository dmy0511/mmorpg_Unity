using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject go = GameObject.Find("Managers");
        Managers mg = go.GetComponent<Managers>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
