using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBlinlingV1 : MonoBehaviour
{
    public GameObject light;
    public float timeMin = 0;
    public float timeMax = 2;
    void Start()
    {
        StartCoroutine("Blink");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Blink()
    {
        while (true)
        {
            light.SetActive(false);
            float wait = Random.Range(timeMin, timeMax);
            yield return new WaitForSeconds(wait);
            light.SetActive(true);
            wait = Random.Range(timeMin, timeMax);
            yield return new WaitForSeconds(wait);
        }
    }
}
