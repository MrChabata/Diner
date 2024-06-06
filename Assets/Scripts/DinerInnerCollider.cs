using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinerInnerCollider : MonoBehaviour
{
    public AudioSource audioSource;
    public float volumeChange = 0.2f;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            audioSource.volume *= volumeChange;
            print("re");
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            audioSource.volume /= volumeChange;
            print("hdhaoeo");
        }
    }
}
