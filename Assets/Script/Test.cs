using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;

public class Test : Agent
{
    public override void Heuristic(in ActionBuffers actionsOut)
    {
        base.Heuristic(actionsOut);
    }

    public override void CollectObservations(VectorSensor sensor)
    {
        base.CollectObservations(sensor);
    }

    public override void OnEpisodeBegin()
    {
        base.OnEpisodeBegin();
    }

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
