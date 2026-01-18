using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class inventory : MonoBehaviour
{
  
    public Dictionary<string, bool> items = new Dictionary<string, bool>()
    {
        {"ladder", false},
        {"Rod", false},
        {"Hat", false}
    };
     public Dictionary<string, bool> shipParts = new Dictionary<string, bool>()
    {
        {"treePart", false},
        {"waterPart", false},
        {"kidPart", false}
    };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void updateUI()
    {
          foreach(var key in items)
        {
            GameObject.Find(key.Key).SetActive(key.Value);
        }
    }
    // Update is called once per frame
    void Update()
    {
      
    }
}
