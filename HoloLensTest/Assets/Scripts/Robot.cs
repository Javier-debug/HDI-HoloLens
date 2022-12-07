﻿using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.SpatialAwareness;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Scripts/MRTK/Examples/ClearSpatialObservations")]

public class Robot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject robot;
    void Start()
    {
        // Get the first Mesh Observer available, generally we have only one registered
        var observer = CoreServices.GetSpatialAwarenessSystemDataProvider<IMixedRealitySpatialAwarenessMeshObserver>();

        // Set to not visible
        observer.DisplayOption = SpatialAwarenessMeshDisplayOptions.None;

        StartCoroutine(LoadRobot());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LoadRobot()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);
        
        //spatialAwarenessSystem.ClearObservations();
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);
        //spatialAwarenessSystem.SuspendObservers();
        //After we have waited 5 seconds print the time again.
        robot.SetActive(true);
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }
}
