using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZAxisPingPong : MonoBehaviour
{
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        
        var zPos = Mathf.PingPong(Time.time, 3);
        transform.localPosition = Vector3.forward * zPos;
    }
}
