using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

            if (inventory.UseItem("Мантировка") == true)
            {
                SceneManager.LoadScene("FinalCutScene");
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
