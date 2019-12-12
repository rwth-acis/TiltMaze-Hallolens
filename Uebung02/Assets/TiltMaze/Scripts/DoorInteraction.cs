using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;
using IInputClickHandler = HoloToolkit.Unity.InputModule.IInputClickHandler;

public class DoorInteraction : MonoBehaviour, IInputClickHandler {

    private DoorController contr;
    private bool state = false;

    // Use this for initialization
    void Start () {
        contr = gameObject.GetComponent<DoorController>();
        contr.DoorOpen = false;
	}

    public void OnInputClicked(InputClickedEventData eventData)
    {
        if(state == false)
        {
            contr.DoorOpen = true;
            state = true;
        }
        else
        {
            contr.DoorOpen = false;
            state = false;
        }
    }

}
