using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using IManipulationHandler = HoloToolkit.Unity.InputModule.IManipulationHandler;
using InputManager = HoloToolkit.Unity.InputModule.InputManager;

public class MazeMover : MonoBehaviour, IManipulationHandler{

	private Vector3 startPosition;
    private Vector3 targetPosition;
    private Vector3 mazeRotation;

	void Start () {
        startPosition = gameObject.transform.position;
    }

	void Update () {
		
	}

    public void OnManipulationUpdated(ManipulationEventData eventData){
        InputManager.Instance.OverrideFocusedObject = gameObject;
        targetPosition = eventData.CumulativeDelta * 100;
        gameObject.transform.parent.transform.rotation = Quaternion.Euler(mazeRotation.x + targetPosition.y, mazeRotation.y, mazeRotation.z - targetPosition.x);
    }

    public void OnManipulationCanceled(ManipulationEventData eventData){
        InputManager.Instance.OverrideFocusedObject = null;
    }

    public void OnManipulationCompleted(ManipulationEventData eventData){
        mazeRotation = gameObject.transform.parent.transform.rotation.eulerAngles;
        InputManager.Instance.OverrideFocusedObject = null;
    }

    public void OnManipulationStarted(ManipulationEventData eventData){
        InputManager.Instance.OverrideFocusedObject = gameObject;
        mazeRotation = gameObject.transform.parent.transform.rotation.eulerAngles;
    }
}
