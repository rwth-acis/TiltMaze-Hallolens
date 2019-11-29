using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using HoloToolkit.Unity.UX;

public class newScriptForDraggableLogic : MonoBehaviour{

    public GameObject myPrefab;
    private BoundingBox box;
    private HandDraggable hand;

	void Start () {
        box = myPrefab.GetComponent<BoundingBox>();
        hand = box.Target.GetComponent<HandDraggable>();
    }
	
	void Update () {
        if(box.IsVisible == true){
            hand.IsDraggingEnabled = true;
        }
        else {
            hand.IsDraggingEnabled = false;
        }
	}
}