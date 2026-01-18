using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class inventory : MonoBehaviour
{
      public GameObject[] item;
      public List<Image> parts;

    public Dictionary<string, bool> items = new Dictionary<string, bool>()
    {
        {"ladder", false},
        {"Rod", false},
        {"propeller", false}
    };
     public Dictionary<string, bool> shipParts = new Dictionary<string, bool>()
    {
        {"thruster", false},
        {"ship leg", false},
        {"ship hull", false}
    };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void updateUI()
    {
          foreach(var key in items)
        {
           foreach(GameObject gameObject in item)
           {
           if(key.Key == gameObject.name)
            {
                gameObject.SetActive(key.Value);
            }
           }
        }
          foreach(var key in shipParts)
        {
           foreach(Image gameObject in parts)
           {
           if(key.Key == gameObject.name)
            {
               if(key.Value == true)
                    {
                        gameObject.color = new Color(255f, 255f, 255f);

                    }
            }
           }
        }
    }
    // Update is called once per frame
    void Update()
    {
      
    }
}
