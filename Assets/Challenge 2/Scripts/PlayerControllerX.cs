using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private int time = 0, curTime = 0, keyPressInterval= 60;
    // Update is called once per frame
    void Update()
    {
        time++; //keyPressInterval = (int)(1.0f / Time.deltaTime);
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && time-curTime>=keyPressInterval)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            curTime = time;
        }
    }
}
