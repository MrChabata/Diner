using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDoorOpening : MonoBehaviour
{
    // Start is called before the first frame update
    public DoorOpening doorOpening;
    public Inventory inventory;
    private bool inTrigger;
    public string key;
    void Start()
    {
        inTrigger = false;
    }
        
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inTrigger == true)
        {
            if (inventory.UseItem(key) == true)
            {
                doorOpening.enabled = true;
            }

        }
        
    }

    public void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
    }

    public void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }
}
