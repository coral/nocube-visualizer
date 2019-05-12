using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using WebSocketSharp;

public class Connection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("benis");
        var ws = new WebSocket("ws://localhost:9000/stream");
        
            ws.OnMessage += (sender, e) =>
                Debug.Log(e.Data);

            ws.Connect();

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
