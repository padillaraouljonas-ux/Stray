using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    private Light lightBulb;

    void Start()
    {
        lightBulb = GetComponentInChildren<Light>();
    }

    public void ToggleLight()
    {
        lightBulb.enabled = !lightBulb.enabled;
    }
}
