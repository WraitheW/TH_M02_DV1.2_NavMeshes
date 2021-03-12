using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleAnimation : Kinematic
{
    FollowPath myMoveType;

    public GameObject[] path;

    // Start is called before the first frame update
    void Start()
    {
        myMoveType = new FollowPath();
        myMoveType.character = this;
        myMoveType.path = path;
    }

    // Update is called once per frame
    void Update()
    {
        steeringUpdate = new SteeringOutput();
        steeringUpdate.linear = myMoveType.getSteering().linear;

        base.Update();
    }
}
