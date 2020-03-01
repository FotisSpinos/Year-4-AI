﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentCarTest : MonoBehaviour
{
    [SerializeField] private AgentCar vehicle;

    private void Update()
    {
        vehicle.SetVehicleInput(Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical"));
    }
}