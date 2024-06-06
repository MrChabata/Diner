using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableStashOpening : MonoBehaviour
{
    public Inventory inventory;
    private bool inTrigger;
    void Start()
    {
        inTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inTrigger == true)
        {

            if (inventory.UseItem("Crowbar") == true)
            {
                print("Curscene");
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
