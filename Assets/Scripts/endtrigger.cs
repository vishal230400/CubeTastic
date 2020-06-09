using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

public class endtrigger : MonoBehaviour
{

    public Game game;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter()
    {
        game.CompleteLevel();
    }
}
