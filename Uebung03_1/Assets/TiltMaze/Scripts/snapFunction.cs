using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity;
using System;
using System.Collections.Generic;

public class snapFunction : MonoBehaviour{

    private SolverHandler solver;

    void Start(){
        solver = gameObject.GetComponent<SolverHandler>();
        solver.enabled = false;
    }

	void Update () {
		
	}
    
    public void turnOnOffSnap(){
        solver.enabled = !solver.enabled;
    }
}

