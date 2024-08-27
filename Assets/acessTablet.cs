using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class acessTablet : MonoBehaviour
{
    public static event Action<bool> TrackStatusEvent;
    public void OnTFound(bool trackStatus){
        //if event !null call event
        TrackStatusEvent?.Invoke(trackStatus);
    }
   
}
