using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteraction : MonoBehaviour
{
    private bool inTrigger;
    public GameObject image;
    public GameObject liltxt;
    public CharecterDialogueController cdc;

    // Start is called before the first frame update
    void Start()
    {
        inTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inTrigger == true)
        {
            image.SetActive(true);
            cdc.DisableMovement();
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        liltxt.SetActive(true);
        inTrigger = true;
    }

    public void OnTriggerExit(Collider other)
    {
        liltxt.SetActive(false);
        inTrigger = false;
    }
}
