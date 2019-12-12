using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using IManipulationHandler = HoloToolkit.Unity.InputModule.IManipulationHandler;
using InputManager = HoloToolkit.Unity.InputModule.InputManager;

public class MazeMover : MonoBehaviour, IManipulationHandler{

	private Vector3 startPosition;
    private Vector3 targetPosition;
    private Vector3 upAxis;
    public float lerpSpeed = 10f;

	void Start () {
        startPosition = transform.position;
    }

    public void OnManipulationUpdated(ManipulationEventData eventData){
        InputManager.Instance.OverrideFocusedObject = gameObject;
        targetPosition = eventData.CumulativeDelta + startPosition;
        upAxis = targetPosition - transform.parent.position;
        transform.parent.up = Vector3.Lerp(transform.parent.up, upAxis, lerpSpeed * Time.deltaTime);
    }

    public void OnManipulationCanceled(ManipulationEventData eventData){
        InputManager.Instance.OverrideFocusedObject = null;
    }

    public void OnManipulationCompleted(ManipulationEventData eventData){
        InputManager.Instance.OverrideFocusedObject = null;
    }

    public void OnManipulationStarted(ManipulationEventData eventData){
        InputManager.Instance.OverrideFocusedObject = gameObject;
    }
}
