using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class UnitMovement : MonoBehaviour
{
    Camera mycam;
    NavMeshAgent myAgent;
    public LayerMask ground;

    private void Start()
    {
        mycam = Camera.main;
        myAgent = GetComponent<NavMeshAgent>();
       
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = mycam.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray,out hit, Mathf.Infinity, ground))
            {
                myAgent.SetDestination(hit.point);
            }
        }
    }
    private void Awake()
    {
        Application.targetFrameRate = 60;
    }

}
