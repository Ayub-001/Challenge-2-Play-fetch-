using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timeDelay = 1;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timeDelay <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
        if (timeDelay >= 0)
        {
            timeDelay -= Time.deltaTime;

        }
    }
}
