using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsCatcher : MonoBehaviour
{
    GameObject Player1 = null;
    Player Player1script;

    // Update is called once per frame
    private void Start()
    {
        if (GameObject.Find("Player1") != null)
        {
            Player1 = GameObject.Find("Player1");
            Player1script = Player1.GetComponent<Player>();
        }
    }
    void Update()
    {

        float direction = 0;
        if (Input.GetKey(KeyCode.D))
        {
            direction = 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction = -1;
        }
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.A))
        {
            direction = 0;
        }
        Player1script.Move(direction);
    }
}
