using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpening : MonoBehaviour
{
    private Animator anim;
    private bool inTrigger;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        inTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inTrigger == true)
        {
            anim.SetTrigger("E");
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
