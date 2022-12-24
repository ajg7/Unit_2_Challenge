using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    float timeInterval = 1f;
    float timer = 1f;

    void Start()
    {
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime * timeInterval;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timer >= timeInterval)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timer = 0f;
        }
    }
}
