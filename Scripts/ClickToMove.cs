using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickToMove : MonoBehaviour
{
    NavMeshAgent _naveMeshAgent;

    void Awake() => _naveMeshAgent = GetComponent<NavMeshAgent>();


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out var hitInfo))
        {
            _naveMeshAgent.SetDestination(hitInfo.point);
        }
    }
}
