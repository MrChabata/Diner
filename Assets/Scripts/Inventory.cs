using System.Collections;
using System.Collections.Generic;
using UnityEditor.Profiling.Memory.Experimental;
using UnityEngine.UI;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    List<string> items = new List<string> ();
    public GameObject inventoryUI;
    public Text txt;

    public void AddItem(string itemName)
    {
        items.Add(itemName);
        print("Добавлен предмет" + itemName);
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

    public bool UseItem(string itemName)
    {
        bool flag = false;
        if(HasItem(itemName))
        {
            RemoveItem(itemName);
            print("Использован предмет:" + itemName);
            flag = true;
        }
        else
        {
            print("В инвентаре нет" +  itemName);
        }
        return flag;
    }

    public void RenderInventory()
    {
        txt.text = "";
        for (int i = 0;i < items.Count;i++) 
        {
            txt.text += items[i] + "\n";
        }
    }

        
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (inventoryUI.activeSelf == false)
            {
                inventoryUI.SetActive(true);
                RenderInventory();
            }
            else
            {
                inventoryUI.SetActive(false);
            }
        }
    }
}
