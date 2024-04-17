using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    List<string> items = new List<string> ();

    public void AddItem(string itemName)
    {
        items.Add(itemName);
    }

    private void RemoveItem(string itemName) 
    {
        List<string> newItems = new List<string>();
        for (int i = 0; i < items.Count; i++) 
        {
            if (items[i] != itemName) 
            {
                newItems.Add(items[i]);
            }
        }
        items = newItems;
    }

    private bool HasItem(string itemName) 
    {
        bool flag = false;
        for (int i = 0; i < items.Count; i++)
        {   
            if (items[i] == itemName)
            {
                flag = true;
            }
        }
        return flag;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
